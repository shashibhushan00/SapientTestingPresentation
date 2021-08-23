import React from "react";

export class ProductPageNumberBar extends React.Component {

    constructor(props) {
        super(props);
        this.state = { pageNumber: 0 };
        this.onInputTextChange = this.onInputTextChange.bind(this);
        this.onFormSubmit = this.onFormSubmit.bind(this);
    }

    onFormSubmit(e) {
        e.preventDefault();
        this.props.pageNumberChanged(this.state.pageNumber);
    }

    onInputTextChange(e) {
        this.setState({ ...this.state, pageNumber: e.target.value });
    }

    render() {
        return (
            <form onSubmit={this.onFormSubmit}>
                <input type="number" min="1" max="5" placeholder="Enter the page number" onChange={this.onInputTextChange} />
                <input type="submit" value="Submit"></input>
            </form>
        );
    }

}