(async function () {


    let data = await $.getJSON("/hentdata");
    for (var i = 0; i < data.length; i++) {
        let li = $("<li />").html(data[i].name);
        $("#liste").append(li);
    }

    var app = new Vue({
        el: '#app',
        data: {
            data: data
        }
    })


})();

