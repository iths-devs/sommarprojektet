import React, { useState } from 'react';
import axios from 'axios';
import { useMsal } from '@azure/msal-react';
// import { useIsAuthenticated } from '@azure/msal-react';

const GetTemplate = () => {
    const [responses, setResponses] = useState<string[]>([]);
    const { instance } = useMsal();

    const get = async () => {
        const account = instance.getAllAccounts()[0];

        const accessTokenRequest = {
            scopes: ['User.Read'],
            account: account,
        };

        const token = await instance.acquireTokenSilent(accessTokenRequest);

        const headers = new Headers();
        const bearer = `Bearer ${token}`;

        headers.append('Authorization', bearer);

        const options = {
            method: 'GET',
            headers: headers,
        };

        const response = await fetch('https://localhost:7156/Template', options);

        if (response.status === 200) {
            const data = await response.json();
            console.log(data);
            /*eslint-disable */
            // prettier-ignore
            setResponses(r => (r = data));
            /*eslint-enable */
            /*eslint-enable */
        }
    };

    return (
        <div className='GetTemplate'>
            <button onClick={get}>click get</button>
            <ul>
                {responses.map((txt, index) => (
                    <li key={index}>{txt}</li>
                ))}
            </ul>
        </div>
    );
};

export default GetTemplate;
