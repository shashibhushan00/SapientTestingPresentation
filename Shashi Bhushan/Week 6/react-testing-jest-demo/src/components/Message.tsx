const Message = (props: Props) => {
  return (
    <p>
      {props.isImportant
        ? <strong title='Important content'>{props.content}</strong>
        : <span title='Regular content'>{props.content}</span>}
    </p>);
};

export default Message;