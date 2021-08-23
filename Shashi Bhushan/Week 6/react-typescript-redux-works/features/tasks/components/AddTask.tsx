import React from 'react'

export const AddTask: React.FC<any> = ({ onSaveTask }) => {

    const addTask = (e: React.FormEvent) => {
        e.preventDefault();
        onSaveTask({
            id: Math.floor(Math.random() * 100) + 1,
            title: "Title",
            description: 'Test Description'
        });
    }

    return (

        <form onSubmit={addTask}>
            <button>AddNewTask</button>
        </form>
    )
}
