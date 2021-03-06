﻿/* General Funtion Section*/
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

    var nbDiskSupp = document.getElementById("nbDiskSupp").value;

    if (nbDiskSupp == 0) {
        $("#thirdDisk").removeClass("d-none");
        document.getElementById("nbDiskSupp").value = 1;
    }
    if (nbDiskSupp == 1) {
        $("#diskSupp").addClass("d-none");
        $("#forthDisk").removeClass("d-none");
        document.getElementById("nbDiskSupp").value = 2;
    }

    

    
}

function saveItem() {
    var choosedItem = document.getElementById('hiddenChoosedItem').value;
    var itemName = location.pathname.split('/Configurator/');
    localStorage.setItem(itemName[1], choosedItem);
}
function readStorageKey(key) {
    
}

function checklistUpdate() {
    if (window.localStorage.getItem("CaseChoice") == null) {
        $("#caseCardBG").addClass("bg-info")
    } else {
        $("#caseCardBG").addClass("bg-success");
    }

    if (window.localStorage.getItem("MotherboardChoice") == null) {
        $("#mbCardBG").addClass("bg-info")
    } else {
        $("#mbCardBG").addClass("bg-success");
    }

    if (window.localStorage.getItem("CpuChoice") == null) {
        $("#cpuCardBG").addClass("bg-info")
    } else {
        $("#cpuCardBG").addClass("bg-success");
    }

    if (window.localStorage.getItem("GpuChoice") == null) {
        $("#gpuCardBG").addClass("bg-info")
    } else {
        $("#gpuCardBG").addClass("bg-success");
    }
}