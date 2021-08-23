import React from 'react'
import { ProductPageNumberBar } from './ProductPageNumberBar'
import { ProductTable } from './ProductTable';

export class ProductTableContainer extends React.Component {

    constructor(props) {
        super(props);
        this.state = { isLoaded: false };
        this.onPageNumberChange = this.onPageNumberChange.bind(this);
    }

    componentDidMount() {
        fetch("https://localhost:5001/productapi?page=1")
            .then(res => res.json())
            .then(
                (result) => {
                    this.setState({
                        isLoaded: true,
                        products: result
                    });
                },
                (error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                }
            )
    }

    onPageNumberChange(value) {
        console.log(`Page Number Entered -> ${value}`);
        fetch(`https://localhost:5001/productapi?page=${value}`)
            .then(res => res.json())
            .then(
                (result) => {
                    this.setState({
                        isLoaded: true,
                        products: result
                    });
                },
                (error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                }
            )
    }
    render() {
        if (this.state.isLoaded) {
            return (
                <div>
                    <ProductPageNumberBar pageNumberChanged={this.onPageNumberChange}></ProductPageNumberBar>
                    <ProductTable products={this.state.products}></ProductTable>
                </div>
            );
        } else {
            return (
                <div>
                    <ProductPageNumberBar context={this} pageNumberChanged={this.onPageNumberChange}></ProductPageNumberBar>
                    <h3>Loading...</h3>
                </div>
            );
        }
    }

}