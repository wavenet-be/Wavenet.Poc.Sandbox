import React from 'react';
import { ClientList } from '../Components/Clients/ClientList';
import { ClientService } from '../Services/ClientService';
import { ClientDetail } from '../Components/Clients/ClientDetail';

interface ClientsProps
{
}

interface ClientsState
{
    clients: any[];
    currentClient: any;
}

export class Clients extends React.Component<ClientsProps, ClientsState>
{
    constructor(props: ClientsProps)
    {
        super(props);

        this.state = {
            clients: [],
            currentClient: null,
        };
    }

    componentDidMount()
    {
        ClientService.getClients().then((data) =>
        {
            this.setState(
                {
                    clients: data,
                },
            );
        });
    }

    clientSelected(selectedClient: any)
    {
        ClientService.getClient(selectedClient.id).then((data) =>
        {
            this.setState({
                currentClient: data,
            });
        });
    }

    render()
    {
        return <div className="container">
            <ClientList clients={this.state.clients} clientSelected={this.clientSelected.bind(this)}/>
            <ClientDetail client={this.state.currentClient}/>
        </div>;
    }
}