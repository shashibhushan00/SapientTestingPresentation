import React from 'react';
import { shallowEqual, useDispatch, useSelector } from 'react-redux';
import * as taskActionCreators from './features/tasks/actions/taskActionCreators';
import { AddTask } from './features/tasks/components/AddTask';
import { Task } from './features/tasks/components/Task';
import './style/App.css';

export const App = (): JSX.Element => {

    const taskList: Tasks = useSelector((state: AppState) => state.tasks, shallowEqual);

    const dispatch = useDispatch();
    const addTask = React.useCallback((task: Task) => {
        dispatch(taskActionCreators.getAddNewTaskAction(task))
    }, [dispatch]);

    return (
        <div className="App">
            <p>App Works</p>
            <AddTask onSaveTask={addTask}></AddTask>
            {
                taskList.map((task: any) => (
                    <Task task={task} key={task.id} />
                ))
            }
        </div>
    );
}