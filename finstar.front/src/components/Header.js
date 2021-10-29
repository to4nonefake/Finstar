import { Row, Col } from "react-bootstrap";

export const Header = () => {
    return <div>
        <Row>
            <Col xs={2}>Code</Col>
            <Col md="auto">Value</Col>
        </Row>
        <hr style={{ border: '1px solid grey' }} />
    </div>
}