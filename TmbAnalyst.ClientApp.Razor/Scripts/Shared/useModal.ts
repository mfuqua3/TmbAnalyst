import {Modal as BootstrapModal} from "bootstrap";

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
    function submit() {
        if(props?.onSubmit) {
            props.onSubmit(instanceArgs);
        }
        close();
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