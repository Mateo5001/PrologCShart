%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% Veamos cómo podríamos resolver el problema, tomando los datos importantes tenemos:
%
% 1-. 6 frascos: rojo, anaranjado, amarillo, verde, azul y violeta
%
% 2-. con veneno uno sí otro no:
%       a) los frascos violeta y azul
%       b) los frascos rojo y amarillo
%       c) los frascos azul y anaranjado
%
% 3-. uno del par no tiene veneno
%       d) el violeta y el amarillo
%       e) el rojo y el anaranjado
%       f) el verde y el azul
%
% 4-. el rojo no es veneno
%
%
% Modelamos los conocimientos y el problema, no es mejor ni una forma ni otra, sino como se vea más claro.


resolver :-
        nl,
	write('El Sr.Despistado, el químico, tiene seis frascos llenos de líquidos coloreados. Hay uno de cada color: rojo, anaranjado, amarillo, verde, azul y violeta. El señor Despistado sabe que algunos de esos líquidos son tóxicos, pero no recuerda cuales...'),
        nl,
	nl,
        write('Sin embargo, sí recuerda algunos datos. En cada uno de los siguientes pares de frascos hay uno con veneno y otro no:

    a) los frascos violeta y azul
    b) los frascos rojo y amarillo
    c) los frascos azul y anaranjado'),
        nl,
	nl,
	write('El Sr. Despistado recuerda también que en estos otros pares de frascos hay uno sin veneno:

    d) el violeta y el amarillo
    e) el rojo y el anaranjado
    f) el verde y el azul

  ¿Qué frascos tienen veneno?'),
        nl,
	assert(no_venenoso(rojo)),
	assert(venenoso(X):-fail),
	assert(no_venenoso(X):-fail),
	assert(visitada_regla(X):-fail),
	procesar.

no(X) :-
	X,
	!,
	fail.
no(X).


% 2-. con veneno uno sí otro no:
%       a) los frascos violeta y azul
%       b) los frascos rojo y amarillo
%       c) los frascos azul y anaranjado

% Regla 1
procesar :-
	venenoso(violeta),
	no(visitada_regla(1)),
	assert(no_venenoso(azul)),
	assert(visitada_regla(1)),
	procesar.

procesar :-
	no_venenoso(violeta),
	no(visitada_regla(1)),
	assert(venenoso(azul)),
	assert(visitada_regla(1)),
	procesar.

procesar :-
	venenoso(azul),
	no(visitada_regla(1)),
	assert(no_venenoso(violeta)),
	assert(visitada_regla(1)),
	procesar.

procesar :-
	no_venenoso(azul),
	no(visitada_regla(1)),
	assert(venenoso(violeta)),
	assert(visitada_regla(1)),
	procesar.

% Regla 2
procesar :-
	venenoso(rojo),
	no(visitada_regla(2)),
	assert(no_venenoso(amarillo)),
	assert(visitada_regla(2)),
	procesar.

procesar :-
	no_venenoso(rojo),
	no(visitada_regla(2)),
	assert(venenoso(amarillo)),
	assert(visitada_regla(2)),
	procesar.

procesar :-
	venenoso(amarillo),
	no(visitada_regla(2)),
	assert(no_venenoso(rojo)),
	assert(visitada_regla(2)),
	procesar.

procesar :-
	no_venenoso(amarillo),
	no(visitada_regla(2)),
	assert(venenoso(rojo)),
	assert(visitada_regla(2)),
	procesar.

% Regla 3
procesar :-
	venenoso(azul),
	no(visitada_regla(3)),
	assert(no_venenoso(anaranjado)),
	assert(visitada_regla(3)),
	procesar.

procesar :-
	no_venenoso(azul),
	no(visitada_regla(3)),
	assert(venenoso(anaranjado)),
	assert(visitada_regla(3)),
	procesar.

procesar :-
	venenoso(anaranjado),
	no(visitada_regla(3)),
	assert(no_venenoso(azul)),
	assert(visitada_regla(3)),
	procesar.

procesar :-
	no_venenoso(anaranjado),
	no(visitada_regla(3)),
	assert(venenoso(azul)),
	assert(visitada_regla(3)),
	procesar.


% 3-. uno del par no tiene veneno
%       d) el violeta y el amarillo
%       e) el rojo y el anaranjado
%       f) el verde y el azul

% Regla 4
procesar:-
	venenoso(violeta),
	no(visitada_regla(4)),
	assert(no_venenoso(amarillo)),
	assert(visitada_regla(4)),
	procesar.

procesar:-
	venenoso(amarillo),
	no(visitada_regla(4)),
	assert(no_venenoso(violeta)),
	assert(visitada_regla(4)),
	procesar.

% Regla 5
procesar:-
	venenoso(rojo),
	no(visitada_regla(5)),
	assert(no_venenoso(anaranjado)),
	assert(visitada_regla(5)),
	procesar.

procesar:-
	venenoso(anaranjado),
	no(visitada_regla(5)),
	assert(no_venenoso(rojo)),
	assert(visitada_regla(5)),
	procesar.

% Regla 6
procesar:-
	venenoso(verde),
	no(visitada_regla(6)),
	assert(no_venenoso(azul)),
	assert(visitada_regla(6)),
	procesar.

procesar:-
	venenoso(azul),
	no(visitada_regla(6)),
	assert(no_venenoso(verde)),
	assert(visitada_regla(6)),
	procesar.

procesar:-
	write('').


cargar(A):- exists_file(A),consult(A).