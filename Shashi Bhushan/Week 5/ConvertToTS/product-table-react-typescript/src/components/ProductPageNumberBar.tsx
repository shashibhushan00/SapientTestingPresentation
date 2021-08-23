import '../style/ProductPageNumberBar.css'

import React from "react";
import IProductPageNumberBarProps from "../models/IProductPageNumberBarProps";
import IProductPageNumberBarState from "../models/IProductPageNumberBarState";

export class ProductPageNumberBar extends React.Component<IProductPageNumberBarProps, IProductPageNumberBarState>  {

    constructor(props: IProductPageNumberBarProps) {
        super(props);
        this.state = { pageNumber: 0 };
        this.onInputTextChange = this.onInputTextChange.bind(this);
        this.onFormSubmit = this.onFormSubmit.bind(this);
    }

    onFormSubmit = (e: React.FormEvent<HTMLFormElement>): void => {
        e.preventDefault();
        this.props.pageNumberChanged(this.state.pageNumber);
    }

    onInputTextChange = (e: React.FormEvent<HTMLInputElement>): void => {
        this.setState({ pageNumber: Number(e.currentTarget.value) });
    }

    render = () => {
        return (
            <form onSubmit={this.onFormSubmit}>
                <input type="number" id="wide" min="1" max="5" placeholder="Enter the page number" onChange={this.onInputTextChange} />
                <input type="submit" value="Submit"></input>
            </form>
        );
    }

}