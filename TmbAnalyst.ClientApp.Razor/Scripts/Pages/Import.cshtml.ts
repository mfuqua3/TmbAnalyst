import {setButtonLoading} from "../Shared/setButtonLoading";
import usePageHandler from "../Shared/usePageHandler";
import {CreateWishlistImportRequest, WishlistImportResultSummary} from "../Models/";
import useAlert, {AlertType} from "../Shared/useAlert";
import SubmitEvent = JQuery.SubmitEvent;

$(Import)

function Import() {
    $("form").on("submit", handleFormSubmit);
    const {post: submit} = usePageHandler<WishlistImportResultSummary>("Csv");
    const {open: alert} = useAlert();

    async function handleFormSubmit(e: SubmitEvent) {
        e.preventDefault();
        const importTextBlock = $("#RawImportString");
        const {resolve} = setButtonLoading("button[type=submit]");
        const importVal = importTextBlock.val().toString();
        const request: CreateWishlistImportRequest = {importString: importVal};
        try {
            const result = await submit(request);
            alert({
                type: AlertType.Success,
                content: `Import Successful. Loaded ${result.wishlistItemCount} wishlist items and 
                ${result.receivedItemCount} received items across ${result.characterCount} characters.`
            });
            importTextBlock.val('');
        } catch (e) {
            alert({
                type: AlertType.Danger,
                content: e.message ?? 'An unexpected error occurred'
            })
        }
        finally {
            resolve();
        }
    }
}