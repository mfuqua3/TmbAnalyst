export enum AlertType {
    Success,
    Info,
    Warning,
    Danger,
}

export interface useAlertProps {
    type?: AlertType,
    content?: string
}

export interface Alert {
    open(openProps?: useAlertProps): void;
    close(): void;
    toggle(): void;
}

function useAlert(): Alert {
    let props: useAlertProps = {
        type: AlertType.Info,
        content: "Alert!"
    }
    const alerts = $(".alert");
    alerts.hide();

    function open(openProps?: useAlertProps) {
        if(openProps){
            props = {...props, ...openProps};
        }
        $("div[role=alert]")
            .removeClass()
            .addClass(`alert ${className()}`)
            .html(props.content)
            .show();
    }

    function close() {
        alerts.hide();
    }

    function toggle() {
        alerts.toggle();
    }

    function className(): string {
        switch (props.type) {
            case AlertType.Success:
                return "alert-success";
            case AlertType.Info:
                return "alert-info";
            case AlertType.Warning:
                return "alert-warning";
            case AlertType.Danger:
                return "alert-danger";

        }
    }

    return {open, close, toggle};
}

export default useAlert;