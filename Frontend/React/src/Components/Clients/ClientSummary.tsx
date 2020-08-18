import React from 'react';

interface ClientSummaryProps
{
    client: any
}

export const ClientSummary = (props: ClientSummaryProps) =>
{
    return <h3>
        <a title={props.client.name}>
            {props.client.name}
        </a>
    </h3>;
};