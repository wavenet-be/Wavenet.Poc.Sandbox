import React from 'react';
import { ClientSummary } from './ClientSummary';

interface ClientListProps
{
    clients: any[];
    clientSelected: (selectedClient: any) => void;
}

export const ClientList = (props: ClientListProps) =>
{
    return <div className="client-list-panel">
        <h2>Liste des clients</h2>

        {props.clients && props.clients.map((client) =>
        {
            return <ClientSummary client={client} clientSelected={props.clientSelected} key={client.id} />
        })}
    </div>;
};