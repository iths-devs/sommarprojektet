import React, { FC, useState } from 'react';
import axios from 'axios';

const GetTemplate: FC = () => {
    const [responses, setResponses] = useState<string[]>([]);
    const get = async () => {
        const res = await axios.get('https://localhost:7156/Template');
        const data = res.data;
        console.log(data);
        setResponses((u) => (u = data));
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
