const initialState = {
    records: [],
}

export const ActionTypes = {
    SET_RECORDS: 'SET_RECORDS',
}

export const ActionCreators = {
    setRecords: payload => ({ type: ActionTypes.SET_RECORDS, payload }),
}

export default function RecordsReducer(state = initialState, action) {
    switch (action.type) {
        case ActionTypes.SET_RECORDS:
            return { ...state, records: [...action.payload] };
        default:
            return state;
    }
}