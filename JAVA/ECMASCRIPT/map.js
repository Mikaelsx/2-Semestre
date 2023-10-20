// FOREACH - VOID
// MAP - NOVO ARRAY MODIFICADO
// FILTER - NOVO ARRAY MODIFICADO
// REDUCE

// const numeros = [1, 2, 5, 10, 300];

// const dobro = numeros.map( (n) => {
//     return n * 2;
// });

// console.log(numeros);
// console.log(dobro);

// ----------------------------------------------------------------------- FILTER

// RETORNA UM NOVO ARRAY APENAS COM OS ELEMENTOS QUE ATENDEM A VALIDAÇÃO

//  const numeros = [1, 2, 5, 10, 300];

//  const maior10 = numeros.filter((e) =>{
//     return e > 10;
//  });

//  console.log(numeros);

// ----------------------------------------------------------------------- FILTER

// const comentarios = [
//     {comentario: "OTIMO", exibe: true},
//     {comentario: "HORRIVEL", exibe: false},
//     {comentario: "BOM", exibe: true},
// ];

// const comentariosOK = comentarios.filter((c) => {
//     return c.exibe === true;
// })

// // FOREACH
// comentariosOK.forEach((c) => {
//     console.log(c.comentario);
// })

// ----------------------------------------------------------------------- REDUCE

//   const numeros = [1, 2, 5, 10, 300];

//   const soma = numeros.reduce((VlInicial, n) => {
//     return VlInicial + n
//   } , 200)

//   console.log(soma);

// PARA RODAR
// node nomedoarquivo.js