import {useAxios} from "./useAxios";


export interface PageHandler<R> {
    get(params: any): Promise<R>,

    post<T>(body: T): Promise<R>
}

function usePageHandler<R>(handler: string): PageHandler<R> {
    const axios = useAxios();

    const headers = {
        "RequestVerificationToken":
            $('input:hidden[name="__RequestVerificationToken"]').val().toString()
    };

    async function get(params: any): Promise<R> {
        params.handler = handler;
        const resp = await axios.get<R>("/", {headers, params});
        return resp.data;
    }

    async function post<T>(body: T): Promise<R> {
        const params = {
            handler: handler
        };
        const url = location.pathname;
        const resp = await axios.post<R>(url, body, {
            headers,
            params
        });
        return resp.data;
    }

    return {
        get, post
    }
}

export default usePageHandler;