let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();

  displayGroceries();

  
  completeItems();
  uncheckItems();
  markAllComplete();
})
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

function completeItems() {
  const items = document.querySelectorAll('li')
  
  items.forEach(item => {
    if (item.classList.contains('completed') == false) {
      item.addEventListener('click', () => {
        item.classList.add('completed');
                     
      })     
    } 
  })
}

function uncheckItems() {
  const items = document.querySelectorAll('li')
  items.forEach(item => {
      item.addEventListener('dblclick', () => {
        item.classList.remove('completed');
      })  
  })
}

function markAllComplete() {
  const items = document.querySelectorAll('li');
  const button = document.querySelector('#toggleAll');
  if (allItemsIncomplete == true) {
    button.addEventListener('click', (event) => {
      items.forEach(item => {
        item.classList.toggle('completed');        
      })
      if (allItemsIncomplete == true) {
        event.target.innerText = 'Mark All Incomplete';
        allItemsIncomplete = false;
      } else if (allItemsIncomplete == false) {
        event.target.innerText = 'Mark All Complete';
        allItemsIncomplete = true;
      }
      
    })
  }
  
}
