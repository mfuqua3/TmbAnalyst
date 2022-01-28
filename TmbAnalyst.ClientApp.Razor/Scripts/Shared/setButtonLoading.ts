export interface ButtonLoading {
    resolve(): void;
}
export function setButtonLoading(selector: string): ButtonLoading {
    const button = $(selector);
    const currentVal = button.html();
    $(selector)
        .prop('disabled',true)
        .html(
        '<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>\n' +
        '  Loading...')
    function resolve() {
        button
            .prop('disabled',false)
            .html(currentVal);
    }
    return {resolve};
}