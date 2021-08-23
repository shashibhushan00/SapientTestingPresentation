type Task = {
    id: number;
    title: string;
    description: string;
}

type Tasks = Task[];

type AppState = {
    tasks: Task[];
    users: any[];
    projects: any[];
}

type AppProps = { taskProp: Tasks }