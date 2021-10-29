import { ActionCreators } from "../redux/recordsReducer";
import * as axios from 'axios';

const axiosInstance = axios.create({
    baseURL: 'https://localhost:44380/Records',
});

export const GetRecords = async (dispatch) => {
    try {
        //Test Values
        /*const response = [
            { id: 1, code: 1,  value: 'value1' },
            { id: 2, code: 5,  value: 'value2' },
            { id: 3, code: 10, value: 'value322' },
        ];*/

        //api
        const { data } = await axiosInstance.get();

        dispatch(ActionCreators.setRecords(data));
    } catch {
        console.log('Error!');
    }
}