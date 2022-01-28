import {Modal as BootstrapModal} from "bootstrap";
import {setButtonLoading} from "./setButtonLoading";

export interface ModalProps<T> {
    onSubmit?(args: T): void | Promise<void>;
}

export interface Modal<T> {
    setArgs(args: T): void;
    open(): void;
    close(): void;
    toggle(): void;
}

function useModal<T>(selector: string, props?: ModalProps<T>): Modal<T> {
    let instanceArgs: T = null;
    const modal = new BootstrapModal(selector);
    $(selector + " " + ".modal-close").on("click", close);
    $(selector + " " + ".modal-submit").on("click", submit);
    async function submit() {
        const {resolve} = setButtonLoading(`.modal-submit`);
        try {
            if(props?.onSubmit) {
                await props.onSubmit(instanceArgs);
            }
            close();
        }
        finally {
            resolve();
        }
    }
    function open() {
        modal.show();
    }
    function setArgs(args: T){
        instanceArgs = args;
    } 
    function close() {
        modal.hide();
    }

    function toggle() {
        modal.toggle();
    }
    return {
        open,
        close,
        toggle,
        setArgs
    }
}

export default useModal