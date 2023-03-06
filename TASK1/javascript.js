

let arr = ['94FMDD4', '1JF92CH3', '3C15N76', '5PGA3G2'];

let fin = window.prompt("Enter your finCode: ");
console.log('finkod is: ',fin);

let re = /^[\w]{7}$/;

if (re.test(fin)) {
        window.alert("userfound", fin); 
}
// else if(re.test(fin)){
//     window.alert("finCode not found, please enter your finCode: ");
// } 
else{
    window.prompt("wrong format, please enter your finCode: ");
    
}