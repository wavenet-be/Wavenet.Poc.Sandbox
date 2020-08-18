import React from 'react';

export interface HelloWorldProps {
    name?: string;
}

export interface HelloWorldState {
    name: string;
}

export class HelloWorld extends React.Component<HelloWorldProps, HelloWorldState>
{
    constructor(props: HelloWorldProps) {
        super(props);

        this.state = {
            name: props.name || ''
        }
    }

    render() {
        return <div className="container">
                    <div className="row">
                        <div className="col">
                            Votre nom : <input value={this.state.name} onChange={(e) => this.setState({name: e.target.value})}></input>
                        </div>
                    </div>
                    <div className="row">
                        <div className="col text-center">
                            <h1>Bonjour {this.state.name} !</h1>
                        </div>
                    </div>
                </div>
            };
}