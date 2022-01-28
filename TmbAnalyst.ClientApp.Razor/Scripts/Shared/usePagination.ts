import {setButtonLoading} from "./setButtonLoading";

export interface PaginationProps {
    totalPages: number;
    canWrap?: boolean;

    onPageInvoke(pageNumber: number): Promise<void>
}

export interface Pagination {
    previous(): Promise<void>;

    next(): Promise<void>;

    goto(pageNumber: number): Promise<void>;
}

const itemTemplate = "<li class=\"page-item\">\n" +
    "                     <button class=\"btn page-link\"></button>\n" +
    "                 </li>"

function usePagination(props: PaginationProps): Pagination {
    const canWrap = props.canWrap ?? false;
    let currentPage = 1;
    const controls = Array.from({length: props.totalPages + 2}, (_, idx) => {
        const item = $(itemTemplate);
        const button = item.find("button.page-link");
        switch (idx) {
            case 0:
                button.on("click", previous)
                    .html("Previous")
                    .prop("disabled", !canWrap);
                break;
            case props.totalPages + 1:
                button.on("click", next)
                    .html("Next");
                break;
            default:
                button.on("click", () => goto(idx))
                    .html((idx).toString());
                break;
        }
        return item;
    });
    $("ul.pagination").empty().append(controls);

    async function next(): Promise<void> {
        if (props.totalPages === currentPage && !canWrap) {
            return;
        }
        let page = currentPage + 1;
        if (page > props.totalPages) {
            page = 1;
        }
        await setPage(page);
    }

    async function previous(): Promise<void> {
        if (1 === currentPage && !canWrap) {
            return;
        }
        let page = currentPage - 1;
        if (page < 1) {
            page = props.totalPages;
        }
        await setPage(page);
    }

    async function goto(pageNumber: number): Promise<void> {
        if (pageNumber > props.totalPages || pageNumber < 1) {
            throw new Error("Provided page number is not a valid index");
        }
        await setPage(pageNumber);
    }

    async function setPage(pageNumber: number): Promise<void> {
        const allControls = $(".pagination button.page-link")
        currentPage = pageNumber;
        await props.onPageInvoke(currentPage);
        let toEnable = allControls;
        if (currentPage === 1 && !canWrap) {
            allControls.first().prop("disabled",true);
            toEnable = allControls.find(":first");
        }
        if (currentPage === props.totalPages && !canWrap) {
            allControls.last().prop("disabled",true);
            toEnable = allControls.not(":last");
        }
        toEnable.prop("disabled", false);
    }

    return {
        next,
        previous,
        goto
    };
}

export default usePagination;