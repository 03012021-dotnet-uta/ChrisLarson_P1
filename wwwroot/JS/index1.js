const newTodo = document.querySelector('.newTodo');
const todoList = document.querySelector('.todoList');
const searchForm = document.querySelector('.searchForm')

newTodo.addEventListener('submit', (event) => { 
    event.preventDefault();
    console.log(newTodo.todo.value);
    //trims any extra whitespace
    const userInput = newTodo.todo.value.trim();
    addNewTodo(userInput);

    //reset the value
    //newTodo.todo.value = '';

    //reset the form
    newTodo.reset();
});
// // adda common class to all the buttons
// let deleteBtn = document.getElementsByClassName("deleteButton");
// // converting html collection to array, to use array methods
// let deleterButton = Array.prototype.slice.call(deleteBtn).forEach(function(item) {
//   // iterate and add the event handler to it
//   item.addEventListener("click", function(e) {
//     e.target.parentNode.remove()
//   });

// })
function removeItem(item){
    var itemToRemove = document.getElementById(item);
    itemToRemove.parentNode.removeChild(itemToRemove);

}
//let count = 0;
function addNewTodo(todo) {
    const html =`
    <li>
        <span class="todoItem">${todo}</span>
        <input class='deletebutton' type="button" value="DELETE"></input>
    </li>`;
    //deleterButton;
    todoList.innerHTML += html;
    //count++;
}

todoList.addEventListener('click',(event) =>{
    if(event.target.classList.contains('deletebutton')){
        event.target.parentElement.remove();
    }
});
//This will listen to the 'keyup' on the form
//and give us the current search term the user is typing
searchForm.addEventListener('keyup', () => {
    console.log(searchForm.search.value);
    const val = searchForm.search.value.trim();
    Array.from(todoList.children)
        .filter((todo) => !todo.textContent.includes(val))
        .forEach((todo) => todo.classList.add('noDisplay'));

    Array.from(todoList.children)
        .filter((todo) => !todo.textContent.includes(val))
        .forEach((todo) => todo.classList.remove('noDisplay'));

    
})


