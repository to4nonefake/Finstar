import React, { useEffect } from "react";
import { Row, Col } from "react-bootstrap";
import { useSelector, useDispatch } from "react-redux";
import { GetRecords } from "../services/records";

export const RecordsTable = () => {
    const records = useSelector(state => state.recordsReducer.records);
    const dispatch = useDispatch();

    useEffect(() => {
        GetRecords(dispatch);
    }, []);

    /*return <table className='table'>
        <tbody>
            {
                records.map(e =>
                    <tr key={e.id} style={{ marginBottom: '1rem' }}>
                        <td style={{ textAlign: 'left' }}>{e.code}</td>
                        <td style={{ textAlign: 'left' }}>{e.value}</td>
                    </tr>
                )
            }
        </tbody>
    </table>*/

    return records.map(e =>
        <div key={e.id} style={{ marginBottom: '1rem' }}>
            <ListRow objective={e} />
            <hr />
        </div>
    );
}

const ListRow = ({ objective }) => {
    return <div>
        <Row>
            <Col xs={2}>{objective.code}</Col>
            <Col md="auto">{objective.value}</Col>
        </Row>
    </div>
}