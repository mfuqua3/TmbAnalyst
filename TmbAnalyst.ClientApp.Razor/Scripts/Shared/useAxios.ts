import axios, {AxiosStatic} from "axios";

export function useAxios(): AxiosStatic {
    axios.defaults.baseURL=(`${location.origin}`);
    axios.defaults.withCredentials = true;
    return axios;
}