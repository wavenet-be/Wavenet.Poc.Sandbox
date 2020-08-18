import React from 'react';

interface ClientSummaryProps
{
    client: any
    clientSelected: (selectedClient: any) => void;
}

export const ClientSummary = (props: ClientSummaryProps) =>
{
    return <h3>
        <a title={props.client.name} onClick={() => props.clientSelected(props.client)}>
            {props.client.name}
        </a>
    </h3>;
};