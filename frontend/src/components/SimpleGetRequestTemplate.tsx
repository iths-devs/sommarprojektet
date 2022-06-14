import React, { useState } from 'react';
import axios from 'axios';

const GetTemplate = () => {
    const [responses, setResponses] = useState<string[]>([]);
    const get = async () => {
        const res = await axios.get('https://localhost:7156/Template');
        const data = res.data;
        console.log(data);
        /*eslint-disable */
        // prettier-ignore
        setResponses(r => (r = data));
        /*eslint-enable */
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
