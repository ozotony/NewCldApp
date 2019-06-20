var oWebViewInterface = window.nsWebViewInterface;

$(document).ready(function () {

       

    var xname = $("input#xname").val();
    var xname2 = $("input#xname2").val();
    var xname3 = $("input#xname3").val();
    var xname4 = $("input#xname4").val();
    var xname5 = $("input#xname5").val();

    var Payment = { ResponseCode: xname, txnref: xname2, PaymentReference: xname3, Email: xname4, Reason: xname5 };

    var aa = "Test"
    // emit event to native app
    oWebViewInterface.emit('anyEvent', Payment);


     });

// register listener for any event from native app
//console.dir(oWebViewInterface);
 
// emit event to native app

