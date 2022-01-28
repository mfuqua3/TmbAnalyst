import useModal from "../Shared/useModal";
import * as moment from "moment";
import {CreateVoteRequest} from "../Models/Requests/CreateVoteRequest";
import {useAxios} from "../Shared/useAxios";
import {VoteSummary} from "../Models/Core/VoteSummary";

function CreatePreVoteModal() {
    const formVal = $("#PreVoteEndDate");
    const axios = useAxios();
    formVal.val(moment().toString());
    const {open} = useModal("#createPreVote", {
        onSubmit: handleSubmit
    });
    $("#nav-create-vote").on("click", open);
    async function handleSubmit(){
        const value = formVal.val().toString();
        const request: CreateVoteRequest = {
            ActiveUntil: moment(value).toDate()
        };
        await axios.post<VoteSummary>('/admin/vote',request, {
            headers: {
                "RequestVerificationToken":
                    $('input:hidden[name="__RequestVerificationToken"]').val().toString()
            }
        });
    }
}
export default CreatePreVoteModal;