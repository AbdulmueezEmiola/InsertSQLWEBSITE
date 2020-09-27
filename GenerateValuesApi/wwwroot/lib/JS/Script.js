function UpdateOptionColumn(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var dataType = document.querySelector("#dataType" + val);
    while (optionColumn.firstChild) {
        optionColumn.removeChild(optionColumn.firstChild);
    }
    switch (dataType.options[dataType.selectedIndex].value) {
        case "Name":
            OptionColumnForName(val);
            break;
        case "Phone":
            OptionColumnForTelephone(val);
            break;
        case "Passport Number":
            OptionColumnForPassport(val);
            break;
        case "Postal/Zip":
            OptionColumnForZipCode(val);
            break;
        case "Fixed Number Of Words":
            OptionColumnForWordsFixed(val);
            break;
        case "Random Number of Words":
            OptionColumnForWordsRange(val);
            break;
        case "Date":
            OptionColumnForDateRange(val);
            break;
        case "Credit Card":
            OptionColumnForCreditCard(val);
            break;
        case "Boolean":
            OptionColumnForBoolean(val);
            break;
        case "AlphaNumeric":
            OptionColumnForAlphaNumeric(val);
            break;
        case "Numbers":
            OptionColumnForNumbers(val);
            break;
        case "List of Words":
            OptionColumnForListOfWords(val);
            break;
    }
}
function OptionColumnForName(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var array = ["First Name(Male)", "First Name(Female)", "Last Name", "Full Name(Male)", "Full Name(Female)", "Initials"];
    //Create and append select list
    var selectList = document.createElement("select");
    selectList.id = "rows[" + val + "]Value"
    selectList.className = "form-control"
    optionColumn.appendChild(selectList);
    selectList.name = "rows[" + val + "].Value";
    //Create and append the options
    for (var i = 0; i < array.length; i++) {
        var option = document.createElement("option");
        option.value = array[i];
        option.text = array[i];
        selectList.appendChild(option);
    }
}
function OptionColumnForNumbers(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.type = "number";
    inputTag.placeholder = "Minimum"
    inputTag.id = "rows[" + val + "]MinValue"
    inputTag.name = "rows[" + val + "].MinValue";
    inputTag.className = "form-control col-5 d-inline-block";
    optionColumn.appendChild(inputTag);
    var inputTag2 = document.createElement("input");
    inputTag2.type = "number";
    inputTag2.name = "rows[" + val + "].MaxValue";
    inputTag2.id = "rows[" + val + "]MaxValue"
    inputTag2.placeholder = "Maximum";
    inputTag2.className = "form-control col-5 d-inline-block float-right";
    optionColumn.appendChild(inputTag2);
}
function OptionColumnForListOfWords(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.id = "rows[" + val + "]Value"
    inputTag.name = "rows[" + val + "].Value";
    inputTag.type = "text";
    inputTag.className = "form-control";
    inputTag.placeholder = "Apple, Banana";
    inputTag.title = "Separate each word with a ',' or a ';'  "
    optionColumn.appendChild(inputTag);
}
function OptionColumnForAlphaNumeric(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.id = "rows[" + val + "]Value"
    inputTag.name = "rows[" + val + "].Value";
    inputTag.type = "text";
    inputTag.className = "form-control";
    inputTag.placeholder = "XNxNNxXX";
    inputTag.title = "Each x stands for a lower case, X for an upper case, and each N stands for a number"
    optionColumn.appendChild(inputTag);
}
function OptionColumnForBoolean(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var array = ["True or False", "T or F", "0 or 1", "Yes or No", "Y or N"];
    //Create and append select list
    var selectList = document.createElement("select");
    selectList.id = "rows[" + val + "]Value"
    selectList.className = "form-control"
    optionColumn.appendChild(selectList);
    selectList.name = "rows[" + val + "].Value";
    //Create and append the options
    for (var i = 0; i < array.length; i++) {
        var option = document.createElement("option");
        option.value = array[i];
        option.text = array[i];
        selectList.appendChild(option);
    }
}
function OptionColumnForPassport(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.id = "rows[" + val + "]Value"
    inputTag.name = "rows[" + val + "].Value";
    inputTag.type = "text";
    inputTag.className = "form-control";
    inputTag.placeholder = "ANNNNNAAA";
    inputTag.title = "Each A stands for an alphabet, and each N stands for a number"
    optionColumn.appendChild(inputTag);
}
function OptionColumnForZipCode(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.name = "rows[" + val + "].Value";
    inputTag.id = "rows[" + val + "]Value";
    inputTag.type = "text";
    inputTag.className = "form-control";
    inputTag.placeholder = "ANNNNN"
    inputTag.title = "Each A stands for an alphabet, and each N stands for a number"
    optionColumn.appendChild(inputTag);
}
function OptionColumnForWordsFixed(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.name = "rows[" + val + "].Value";
    inputTag.id = "rows[" + val + "]Value";
    inputTag.type = "number";
    inputTag.className = "form-control";
    optionColumn.appendChild(inputTag);
}
function OptionColumnForWordsRange(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.type = "number";
    inputTag.placeholder = "Minimum"
    inputTag.id = "rows[" + val + "]MinValue"
    inputTag.name = "rows[" + val + "].MinValue";
    inputTag.className = "form-control col-5 d-inline-block";
    optionColumn.appendChild(inputTag);
    var inputTag2 = document.createElement("input");
    inputTag2.type = "number";
    inputTag2.name = "rows[" + val + "].MaxValue";
    inputTag2.id = "rows[" + val + "]MaxValue"
    inputTag2.placeholder = "Maximum";
    inputTag2.className = "form-control col-5 d-inline-block float-right";
    optionColumn.appendChild(inputTag2);
}
function OptionColumnForDateRange(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.type = "datetime";
    inputTag.name = "rows[" + val + "].MinValue";
    inputTag.id = "rows[" + val + "]MinValue";
    inputTag.placeholder = "Min Date";
    inputTag.className = "form-control col-5 d-inline-block";
    optionColumn.appendChild(inputTag);
    var inputTag2 = document.createElement("input");
    inputTag2.name = "rows[" + val + "].MaxValue";
    inputTag2.id = "rows[" + val + "]MaxValue"
    inputTag2.type = "datetime";
    inputTag2.placeholder = "Max Date";
    inputTag2.className = "form-control col-5 d-inline-block float-right";
    optionColumn.appendChild(inputTag2);
}
function OptionColumnForCreditCard(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var array = ["MASTERCARD", "VISA", "OTHERS"];
    //Create and append select list
    var selectList = document.createElement("select");
    selectList.name = "rows[" + val + "].Value";
    selectList.id = "rows[" + val + "]Value"
    selectList.id = "selectId" + val;
    selectList.className = "form-control"
    optionColumn.appendChild(selectList);

    //Create and append the options
    for (var i = 0; i < array.length; i++) {
        var option = document.createElement("option");
        option.value = array[i];
        option.text = array[i];
        selectList.appendChild(option);
    }
}
function deleteRow(btn) {
    var row = btn.parentNode.parentNode;
    row.parentNode.removeChild(row);
    NumberRow();
}
function NumberRow() {
    var rows = document.getElementById("TableData").rows;
    for (var i = 1; i < rows.length - 1; i++) {
        var column = rows[i].cells[0];
        column.innerHTML = i - 1;
    }
}
function AddNewRow() {   
    var tbody = document.querySelector("tbody");
    var rows = tbody.rows;
    var newRow = tbody.insertRow(rows.length);
    var cell1 = newRow.insertCell(0);
    cell1.innerHTML = rows.length-1;
    var cell2 = newRow.insertCell(1);
    cell2.innerHTML = "<input type='text' class='form-control' name='Rows[" + (rows.length-1) + "].ColumnName'/>";
    var cell3 = newRow.insertCell(2);
    var cell4 = newRow.insertCell(3);
    cell4.id = "optionColumn" + (rows.length - 1);
    var cell5 = newRow.insertCell(4);
    cell5.innerHTML = "<button class='btn btn-danger' onclick='deleteRow(this)'>Delete</button>"    
    var url = "/Home/SelectDataType/";
    $.ajax({
        url: url,
        Cache: false,
        data: { "value":rows.length-1 },
        type: "POST",
        success: function (data) {
            cell3.innerHTML = data;
        },
        error: function (response) {
            alert("error : " + response);
        }
    })
}
function ProcessTable() {
    var tbody = document.querySelector("tbody")
    var listOfValues = []
    for ( var i = 0; i < tbody.rows.length; i++) {
        var objCells = tbody.rows.item(i).cells;
        var RowViewModel = {};
        if (objCells[1].querySelector('input').value != "") {
            RowViewModel['ColumnName'] = objCells[1].querySelector('input').value
            RowViewModel['DataType'] = objCells[2].querySelector('select').value
            cellChildren = objCells[3].children
            if (cellChildren.length == 1) {
                RowViewModel['Value'] = cellChildren[0].value
            } else if (cellChildren.length == 2) {
                RowViewModel['MinValue'] = cellChildren[0].value
                RowViewModel['MaxValue'] = cellChildren[1].value
            }
            listOfValues.push(RowViewModel)
        }
    }
    return listOfValues;
}
/*function GenerateResult() {
    var url = "/Home/ProcessRequest";
    var tableNameTag = document.querySelector("#TableName");
    var databaseTypeTag = document.querySelector("#DatabaseType");
    var rowNumbersTag = document.querySelector("#RowNumbers");
    var batchSizeTag = document.querySelector("#BatchSize");
    var resultTag = document.querySelector("#Result")
    var validation = document.querySelector('.validation')
    ProcessTable()
    $.ajax({
        url: url,
        type: "POST",
        data: {
            "dataTypeViewModel.BatchSize": batchSizeTag.value,
            "dataTypeViewModel.RowNumbers": rowNumbersTag.value,
            "dataTypeViewModel.DatabaseType": databaseTypeTag.value,
            "dataTypeViewModel.TableName": tableNameTag.value,
            "dataTypeViewModel.Rows": ProcessTable()
        },
        success: function (data) {
            validation.classList.remove('invisible')
            console.log("Here")            
        },
        error: function (xhr, httpStatusMessage, customErrorMessage) {
            if (xhr.status = 400) {
                $.ajax({
                    url: "/Home/ProcessRequestContinuationOnFail",
                    type: "POST",
                    data: {
                        "dataTypeViewModel.BatchSize": batchSizeTag.value,
                        "dataTypeViewModel.RowNumbers": rowNumbersTag.value,
                        "dataTypeViewModel.DatabaseType": databaseTypeTag.value,
                        "dataTypeViewModel.TableName": tableNameTag.value,
                        "dataTypeViewModel.Rows": ProcessTable()
                    }
                })
            }
        },
        failure: function (response) {
            alert(response.responseText);
        },  
    })
}*/
function copyResult() {
    var resultList = document.querySelector("#Result ul")
    var selection = window.getSelection()
    var range = document.createRange()
    range.selectNodeContents(resultList);
    selection.removeAllRanges();
    selection.addRange(range);
    document.execCommand('copy');
    alert("The text has been copied");

}
function OptionColumnForTelephone(val) {
    var optionColumn = document.querySelector("#optionColumn" + val);
    var inputTag = document.createElement("input");
    inputTag.type = "text";
    inputTag.className = "form-control";
    inputTag.placeholder = "234-xxxx-xxxx"
    inputTag.name = "rows[" + val + "].Value";
    inputTag.title = "for each x inputed, a random number is generated, if at a particular position, you want a particular number, put the number"
    optionColumn.appendChild(inputTag);
}