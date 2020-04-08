/* General Funtion Section*/
function chooseItem(id) {
    $('.selected-item').removeClass('selected-item');
    $('.disabled').removeClass('disabled');

    var selectedItem = document.getElementById("item" + id);
    var selectedItemBtn = document.getElementById("btnItem" + id);
    selectedItem.className += " selected-item";
    selectedItemBtn.className += " disabled";
    document.getElementById('hiddenChoosedItem').value = selectedItem.id;
};

function nextPage() {
    var choosedItem = document.getElementById('hiddenChoosedItem').value;
    $.ajax({
        url: window.location.href,
        type: 'POST',
        dataType: 'text',
        data: {
            'choosedItem': choosedItem
        }});
}

/*Storage Section*/
function addDisk() {
    alert("Do that please");
}

function saveItem() {
    var choosedItem = document.getElementById('hiddenChoosedItem').value;
    var itemName = location.pathname.split('/Configurator/');
    localStorage.setItem(itemName[1], choosedItem);
}
function readStorageKey(key) {
    
}
