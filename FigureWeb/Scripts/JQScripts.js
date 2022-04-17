$(document).ready(function () {
    DeleteLetters();
});

function DeleteLetters() {
    $('input').bind("change keyup input click", function () {
        if (this.value.match(/[^0-9.]/g)) {
            this.value = this.value.replace(/[^0-9.]/g, '');
        }
    });
}

function ToggleRound() {
    $('#BlockRound').toggle('slow');
}

function ToggleTriangle() {
    $('#BlockTriangle').toggle('slow');
}

function ToggleFigure() {
    $('#BlockFigure').toggle('slow');
}

function AppendBlockFigure() {
    $('#inDoorSquare').append(
        '<div class="AloneTriangle">' + 
        '<div class="col-sm-12 row AllBlocks">' +
        '<span class="col-sm-3">Введите длину внутреннего прямоугольника: </span>' + 
        '<input class="form-control col-sm-9 IndoorRectangleWidth" type="text" onkeyup="DeleteLetters()">' +
        '</div>' +
        '<div class="col-sm-12 row AllBlocks">' +
        '<span class="col-sm-3">Введите ширину внутреннего прямоугольника: </span>' +
        '<input class="form-control col-sm-9 IndoorRectangleHeigh" type="text" onkeyup="DeleteLetters()">' +
        '</div>' +
        '</div>'
    );
}

function GetAreaRound() {
    if ($('#txtRound').val() == '') return;
    var obj = new Object;
    obj.Radius = Number($('#txtRound').val());
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Main/GetAreaRound",
        data: JSON.stringify(obj),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            $('#ResultRound').text('Результат:  ' + data.Area);
        }
    });
}

function GetAreaTriangle() {
    if ($('#txtTriangleA').val() == '' || $('#txtTriangleB').val() == '' || $('#txtTriangleC').val() == '') return;

    var obj = new Object;
    obj.SideA = Number($('#txtTriangleA').val());
    obj.SideB = Number($('#txtTriangleB').val());
    obj.SideC = Number($('#txtTriangleC').val());
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Main/GetAreaTriangle",
        data: JSON.stringify(obj),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            var result = "";
            if (data.IsRectangular == true)
                result = "Треугольник прямоугольный. ";
            else result = "Треугольник не прямоугольный. ";
            $('#ResultTriangle').text('Результат: ' + result + ' Площадь: ' + data.Area);
        }
    });
}


function GetAreaFigure() {
    var LittleFigures = [];
    $('.AloneTriangle').each(function (index, el) {
        if (Number($(el).find('.IndoorRectangleWidth').val()) < 0 || Number($(el).find('.IndoorRectangleWidth').val()) == '') return false;
        if (Number($(el).find('.IndoorRectangleHeigh').val()) < 0 || Number($(el).find('.IndoorRectangleHeigh').val()) == '') return false;

        var area = Number($(el).find('.IndoorRectangleWidth').val()) * Number($(el).find('.IndoorRectangleHeigh').val());
        LittleFigures.push(area);
    });

    if (Number($('#txtRectangleA').val()) < 0 || Number($('#txtRectangleA').val()) == '') return false;
    if (Number($('#txtRectangleB').val()) < 0 || Number($('#txtRectangleB').val()) == '') return false;

    var BigFigure = Number($('#txtRectangleA').val()) * Number($('#txtRectangleB').val());

    var obj = new Object;
    obj.BigSquareArea = BigFigure;
    obj.LittleSquareArea = LittleFigures;
    $.ajax({
        type: "POST",
        url: window.location.origin + "/Main/GetAreaUnnowFigure",
        data: JSON.stringify(obj),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            $('#ResultRectangle').text('Результат: ' + data.Area);
        }
    });
}


