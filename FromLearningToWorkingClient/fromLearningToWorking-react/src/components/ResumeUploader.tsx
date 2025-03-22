import React, { useState } from 'react';
import axios from 'axios';

const ResumeUploader = () => {
    const [file, setFile] = useState(null);

    const handleFileChange = (event) => {
        setFile(event.target.files[0]);
    };

    const handleUpload = async () => {
        const formData = new FormData();
        formData.append('file', file);
        formData.append('userId', 'your-user-id'); // קוד המשתמש
        formData.append('uploadDate', new Date().toISOString()); // תאריך העלאה

        try {
            const response = await axios.post('http://your-server-url/upload', formData, {
                headers: {
                    'Content-Type': 'multipart/form-data',
                },
            });
            console.log('File uploaded successfully', response.data);
        } catch (error) {
            console.error('Error uploading file', error);
        }
    };

    return (
        <div>
            <input type="file" onChange={handleFileChange} />
            <button onClick={handleUpload}>Upload Resume</button>
        </div>
    );
};

export default ResumeUploader;
