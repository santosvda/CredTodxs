import { Solicitacao } from "./Solicitacao";

export interface Oferta {
    id:  number; 
    idsolicitacao:  number; 
    solicitacao:  Solicitacao;
    qtdparcelas:  number; 
    valorparcelas:  number; 
    cet:  number; 
    juros:  number; 
    formapagamento:  number; 
    datavencimento:  Date;
    tipocredito:  number; 
}
