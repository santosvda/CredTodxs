import { Pessoa } from "./Pessoa";

export interface Solicitacao {

    id: number;
    idPessoa: number;
    pessoa: Pessoa;
    qtdSolicitada: number;
    rendaMensal: number;
    residencia: number;
    brasileiro: boolean;
    cidadeNatal: string;
    ufNatal: string;
    nomeMae: string;
}
