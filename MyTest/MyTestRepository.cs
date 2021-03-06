﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("a3b62d00-ea46-4821-9eda-43b9617cd069")]
    public partial class MyTestRepository : RepoGenBaseFolder
    {
        static MyTestRepository instance = new MyTestRepository();
        MyTestRepositoryFolders.SCVRetaguardaAppFolder _scvretaguarda;
        MyTestRepositoryFolders.ProblemasEncontradosAppFolder _problemasencontrados;
        MyTestRepositoryFolders.SCVRetaguardaSistemaDeGestaoAppFolder _scvretaguardasistemadegestao;
        MyTestRepositoryFolders.ContextMenuSCVAppFolder _contextmenuscv;
        MyTestRepositoryFolders.FrmPrincipalAppFolder _frmprincipal;
        MyTestRepositoryFolders.GeradorDeCPF4DevsGoogleChromeAppFolder _geradordecpf4devsgooglechrome;
        MyTestRepositoryFolders.ExplorerAppFolder _explorer;
        MyTestRepositoryFolders.FrmNotificacaoAppFolder _frmnotificacao;
        MyTestRepositoryFolders.ConsultaCadastroDeCidadesAppFolder _consultacadastrodecidades;

        /// <summary>
        /// Gets the singleton class instance representing the MyTestRepository element repository.
        /// </summary>
        [RepositoryFolder("a3b62d00-ea46-4821-9eda-43b9617cd069")]
        public static MyTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTestRepository() 
            : base("MyTestRepository", "/", null, 0, false, "a3b62d00-ea46-4821-9eda-43b9617cd069", ".\\RepositoryImages\\MyTestRepositorya3b62d00.rximgres")
        {
            _scvretaguarda = new MyTestRepositoryFolders.SCVRetaguardaAppFolder(this);
            _problemasencontrados = new MyTestRepositoryFolders.ProblemasEncontradosAppFolder(this);
            _scvretaguardasistemadegestao = new MyTestRepositoryFolders.SCVRetaguardaSistemaDeGestaoAppFolder(this);
            _contextmenuscv = new MyTestRepositoryFolders.ContextMenuSCVAppFolder(this);
            _frmprincipal = new MyTestRepositoryFolders.FrmPrincipalAppFolder(this);
            _geradordecpf4devsgooglechrome = new MyTestRepositoryFolders.GeradorDeCPF4DevsGoogleChromeAppFolder(this);
            _explorer = new MyTestRepositoryFolders.ExplorerAppFolder(this);
            _frmnotificacao = new MyTestRepositoryFolders.FrmNotificacaoAppFolder(this);
            _consultacadastrodecidades = new MyTestRepositoryFolders.ConsultaCadastroDeCidadesAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a3b62d00-ea46-4821-9eda-43b9617cd069")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SCVRetaguarda folder.
        /// </summary>
        [RepositoryFolder("48b39dc2-1d6f-4ed4-9c3b-75e13508eec9")]
        public virtual MyTestRepositoryFolders.SCVRetaguardaAppFolder SCVRetaguarda
        {
            get { return _scvretaguarda; }
        }

        /// <summary>
        /// The ProblemasEncontrados folder.
        /// </summary>
        [RepositoryFolder("5498b6ef-dffa-48b3-9db6-6beca8982624")]
        public virtual MyTestRepositoryFolders.ProblemasEncontradosAppFolder ProblemasEncontrados
        {
            get { return _problemasencontrados; }
        }

        /// <summary>
        /// The SCVRetaguardaSistemaDeGestao folder.
        /// </summary>
        [RepositoryFolder("c77f0027-049d-4bc4-a4c0-c1af77175384")]
        public virtual MyTestRepositoryFolders.SCVRetaguardaSistemaDeGestaoAppFolder SCVRetaguardaSistemaDeGestao
        {
            get { return _scvretaguardasistemadegestao; }
        }

        /// <summary>
        /// The ContextMenuSCV folder.
        /// </summary>
        [RepositoryFolder("ceed98ef-fbc6-4813-9fba-4bb7f7a80b83")]
        public virtual MyTestRepositoryFolders.ContextMenuSCVAppFolder ContextMenuSCV
        {
            get { return _contextmenuscv; }
        }

        /// <summary>
        /// The FrmPrincipal folder.
        /// </summary>
        [RepositoryFolder("b8401615-0057-414d-aa2e-5387aaad5706")]
        public virtual MyTestRepositoryFolders.FrmPrincipalAppFolder FrmPrincipal
        {
            get { return _frmprincipal; }
        }

        /// <summary>
        /// The GeradorDeCPF4DevsGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("db1c7825-cfae-45d8-8ee4-2201be0a96b1")]
        public virtual MyTestRepositoryFolders.GeradorDeCPF4DevsGoogleChromeAppFolder GeradorDeCPF4DevsGoogleChrome
        {
            get { return _geradordecpf4devsgooglechrome; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("3fce3ead-9b07-43c3-9e2d-3c7f6ba599f6")]
        public virtual MyTestRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The FrmNotificacao folder.
        /// </summary>
        [RepositoryFolder("76663ef8-3302-4b66-931b-2481d1e6b828")]
        public virtual MyTestRepositoryFolders.FrmNotificacaoAppFolder FrmNotificacao
        {
            get { return _frmnotificacao; }
        }

        /// <summary>
        /// The ConsultaCadastroDeCidades folder.
        /// </summary>
        [RepositoryFolder("e17fa419-9ee6-43b5-beaf-46a99e1ef168")]
        public virtual MyTestRepositoryFolders.ConsultaCadastroDeCidadesAppFolder ConsultaCadastroDeCidades
        {
            get { return _consultacadastrodecidades; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTestRepositoryFolders
    {
        /// <summary>
        /// The SCVRetaguardaAppFolder folder.
        /// </summary>
        [RepositoryFolder("48b39dc2-1d6f-4ed4-9c3b-75e13508eec9")]
        public partial class SCVRetaguardaAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _edtloginInfo;
            RepoItemInfo _buttonlogarInfo;
            RepoItemInfo _senhaInfo;
            RepoItemInfo _edtsenhaInfo;

            /// <summary>
            /// Creates a new SCVRetaguarda  folder.
            /// </summary>
            public SCVRetaguardaAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SCVRetaguarda", "/form[@name='frmLogin']", parentFolder, 30000, null, true, "48b39dc2-1d6f-4ed4-9c3b-75e13508eec9", "")
            {
                _edtloginInfo = new RepoItemInfo(this, "EdtLogin", "text[@name='edtLogin']", 30000, null, "91d880c8-c740-40ff-a69f-bf88b98b3895");
                _buttonlogarInfo = new RepoItemInfo(this, "ButtonLogar", "button[@name='cxbtnlogar']", 30000, null, "812cbf7a-0367-4ffd-b487-168acd70a2cc");
                _senhaInfo = new RepoItemInfo(this, "Senha", "text[@name='Label4']", 30000, null, "c8bb82ca-6dba-4f4f-8976-026bc0aeb37d");
                _edtsenhaInfo = new RepoItemInfo(this, "EdtSenha", "text[@name='edtSenha']", 30000, null, "2b003ae3-ef3b-4fce-a18e-6ceacdefeaa4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("48b39dc2-1d6f-4ed4-9c3b-75e13508eec9")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("48b39dc2-1d6f-4ed4-9c3b-75e13508eec9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EdtLogin item.
            /// </summary>
            [RepositoryItem("91d880c8-c740-40ff-a69f-bf88b98b3895")]
            public virtual Ranorex.Text EdtLogin
            {
                get
                {
                    return _edtloginInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EdtLogin item info.
            /// </summary>
            [RepositoryItemInfo("91d880c8-c740-40ff-a69f-bf88b98b3895")]
            public virtual RepoItemInfo EdtLoginInfo
            {
                get
                {
                    return _edtloginInfo;
                }
            }

            /// <summary>
            /// The ButtonLogar item.
            /// </summary>
            [RepositoryItem("812cbf7a-0367-4ffd-b487-168acd70a2cc")]
            public virtual Ranorex.Button ButtonLogar
            {
                get
                {
                    return _buttonlogarInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonLogar item info.
            /// </summary>
            [RepositoryItemInfo("812cbf7a-0367-4ffd-b487-168acd70a2cc")]
            public virtual RepoItemInfo ButtonLogarInfo
            {
                get
                {
                    return _buttonlogarInfo;
                }
            }

            /// <summary>
            /// The Senha item.
            /// </summary>
            [RepositoryItem("c8bb82ca-6dba-4f4f-8976-026bc0aeb37d")]
            public virtual Ranorex.Text Senha
            {
                get
                {
                    return _senhaInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Senha item info.
            /// </summary>
            [RepositoryItemInfo("c8bb82ca-6dba-4f4f-8976-026bc0aeb37d")]
            public virtual RepoItemInfo SenhaInfo
            {
                get
                {
                    return _senhaInfo;
                }
            }

            /// <summary>
            /// The EdtSenha item.
            /// </summary>
            [RepositoryItem("2b003ae3-ef3b-4fce-a18e-6ceacdefeaa4")]
            public virtual Ranorex.Text EdtSenha
            {
                get
                {
                    return _edtsenhaInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EdtSenha item info.
            /// </summary>
            [RepositoryItemInfo("2b003ae3-ef3b-4fce-a18e-6ceacdefeaa4")]
            public virtual RepoItemInfo EdtSenhaInfo
            {
                get
                {
                    return _edtsenhaInfo;
                }
            }
        }

        /// <summary>
        /// The ProblemasEncontradosAppFolder folder.
        /// </summary>
        [RepositoryFolder("5498b6ef-dffa-48b3-9db6-6beca8982624")]
        public partial class ProblemasEncontradosAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _okenterInfo;
            RepoItemInfo _mmomensagemInfo;

            /// <summary>
            /// Creates a new ProblemasEncontrados  folder.
            /// </summary>
            public ProblemasEncontradosAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ProblemasEncontrados", "/form[@name='frmErro']", parentFolder, 30000, null, true, "5498b6ef-dffa-48b3-9db6-6beca8982624", "")
            {
                _okenterInfo = new RepoItemInfo(this, "OKEnter", "?/?/button[@name='cxbtnConfirma']", 30000, null, "7fb58535-0fbe-4ca4-9093-b1365196d52b");
                _mmomensagemInfo = new RepoItemInfo(this, "MmoMensagem", "?/?/text[@name='mmoMensagem']", 30000, null, "643a9ae2-2ff7-4fd8-8013-ac05e2724bf6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5498b6ef-dffa-48b3-9db6-6beca8982624")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5498b6ef-dffa-48b3-9db6-6beca8982624")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OKEnter item.
            /// </summary>
            [RepositoryItem("7fb58535-0fbe-4ca4-9093-b1365196d52b")]
            public virtual Ranorex.Button OKEnter
            {
                get
                {
                    return _okenterInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The OKEnter item info.
            /// </summary>
            [RepositoryItemInfo("7fb58535-0fbe-4ca4-9093-b1365196d52b")]
            public virtual RepoItemInfo OKEnterInfo
            {
                get
                {
                    return _okenterInfo;
                }
            }

            /// <summary>
            /// The MmoMensagem item.
            /// </summary>
            [RepositoryItem("643a9ae2-2ff7-4fd8-8013-ac05e2724bf6")]
            public virtual Ranorex.Text MmoMensagem
            {
                get
                {
                    return _mmomensagemInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The MmoMensagem item info.
            /// </summary>
            [RepositoryItemInfo("643a9ae2-2ff7-4fd8-8013-ac05e2724bf6")]
            public virtual RepoItemInfo MmoMensagemInfo
            {
                get
                {
                    return _mmomensagemInfo;
                }
            }
        }

        /// <summary>
        /// The SCVRetaguardaSistemaDeGestaoAppFolder folder.
        /// </summary>
        [RepositoryFolder("c77f0027-049d-4bc4-a4c0-c1af77175384")]
        public partial class SCVRetaguardaSistemaDeGestaoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _imgprincipalInfo;
            RepoItemInfo _menuitemcadastrosInfo;

            /// <summary>
            /// Creates a new SCVRetaguardaSistemaDeGestao  folder.
            /// </summary>
            public SCVRetaguardaSistemaDeGestaoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SCVRetaguardaSistemaDeGestao", "/form[@name='frmPrincipal']", parentFolder, 30000, null, true, "c77f0027-049d-4bc4-a4c0-c1af77175384", "")
            {
                _imgprincipalInfo = new RepoItemInfo(this, "ImgPrincipal", "picture[@name='imgPrincipal']", 30000, null, "84386145-3a09-4545-b303-d026df221a92");
                _menuitemcadastrosInfo = new RepoItemInfo(this, "MenuItemCadastros", "?/?/menuitem[@name='Cadastros1']", 30000, null, "52d8cd90-5f04-4893-bc6c-5472ea616979");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c77f0027-049d-4bc4-a4c0-c1af77175384")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c77f0027-049d-4bc4-a4c0-c1af77175384")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ImgPrincipal item.
            /// </summary>
            [RepositoryItem("84386145-3a09-4545-b303-d026df221a92")]
            public virtual Ranorex.Picture ImgPrincipal
            {
                get
                {
                    return _imgprincipalInfo.CreateAdapter<Ranorex.Picture>(true);
                }
            }

            /// <summary>
            /// The ImgPrincipal item info.
            /// </summary>
            [RepositoryItemInfo("84386145-3a09-4545-b303-d026df221a92")]
            public virtual RepoItemInfo ImgPrincipalInfo
            {
                get
                {
                    return _imgprincipalInfo;
                }
            }

            /// <summary>
            /// The MenuItemCadastros item.
            /// </summary>
            [RepositoryItem("52d8cd90-5f04-4893-bc6c-5472ea616979")]
            public virtual Ranorex.MenuItem MenuItemCadastros
            {
                get
                {
                    return _menuitemcadastrosInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItemCadastros item info.
            /// </summary>
            [RepositoryItemInfo("52d8cd90-5f04-4893-bc6c-5472ea616979")]
            public virtual RepoItemInfo MenuItemCadastrosInfo
            {
                get
                {
                    return _menuitemcadastrosInfo;
                }
            }
        }

        /// <summary>
        /// The ContextMenuSCVAppFolder folder.
        /// </summary>
        [RepositoryFolder("ceed98ef-fbc6-4813-9fba-4bb7f7a80b83")]
        public partial class ContextMenuSCVAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _menuitemInfo;
            RepoItemInfo _menuitem1Info;

            /// <summary>
            /// Creates a new ContextMenuSCV  folder.
            /// </summary>
            public ContextMenuSCVAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ContextMenuSCV", "/contextmenu[@processname='SCV']", parentFolder, 30000, null, false, "ceed98ef-fbc6-4813-9fba-4bb7f7a80b83", "")
            {
                _menuitemInfo = new RepoItemInfo(this, "MenuItem", "contextmenu/menuitem[1]", 30000, null, "0f9b6056-92cd-4a6b-8b57-0e6ce3e823ae");
                _menuitem1Info = new RepoItemInfo(this, "MenuItem1", "contextmenu/menuitem[2]", 30000, null, "11189070-683b-4687-82e1-35a45cf843f0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ceed98ef-fbc6-4813-9fba-4bb7f7a80b83")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ceed98ef-fbc6-4813-9fba-4bb7f7a80b83")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MenuItem item.
            /// </summary>
            [RepositoryItem("0f9b6056-92cd-4a6b-8b57-0e6ce3e823ae")]
            public virtual Ranorex.MenuItem MenuItem
            {
                get
                {
                    return _menuitemInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItem item info.
            /// </summary>
            [RepositoryItemInfo("0f9b6056-92cd-4a6b-8b57-0e6ce3e823ae")]
            public virtual RepoItemInfo MenuItemInfo
            {
                get
                {
                    return _menuitemInfo;
                }
            }

            /// <summary>
            /// The MenuItem1 item.
            /// </summary>
            [RepositoryItem("11189070-683b-4687-82e1-35a45cf843f0")]
            public virtual Ranorex.MenuItem MenuItem1
            {
                get
                {
                    return _menuitem1Info.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItem1 item info.
            /// </summary>
            [RepositoryItemInfo("11189070-683b-4687-82e1-35a45cf843f0")]
            public virtual RepoItemInfo MenuItem1Info
            {
                get
                {
                    return _menuitem1Info;
                }
            }
        }

        /// <summary>
        /// The FrmPrincipalAppFolder folder.
        /// </summary>
        [RepositoryFolder("b8401615-0057-414d-aa2e-5387aaad5706")]
        public partial class FrmPrincipalAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _versaodetestesnaousaremproducaoInfo;

            /// <summary>
            /// Creates a new FrmPrincipal  folder.
            /// </summary>
            public FrmPrincipalAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmPrincipal", "/form[@controlname='frmPrincipal']", parentFolder, 30000, null, true, "b8401615-0057-414d-aa2e-5387aaad5706", "")
            {
                _versaodetestesnaousaremproducaoInfo = new RepoItemInfo(this, "VersaoDeTestesNaoUsarEmProducao", "text[@name='lblTeste']", 30000, null, "76b1ac75-aa1d-49a6-99f4-8bd46c53ccbf");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b8401615-0057-414d-aa2e-5387aaad5706")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b8401615-0057-414d-aa2e-5387aaad5706")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The VersaoDeTestesNaoUsarEmProducao item.
            /// </summary>
            [RepositoryItem("76b1ac75-aa1d-49a6-99f4-8bd46c53ccbf")]
            public virtual Ranorex.Text VersaoDeTestesNaoUsarEmProducao
            {
                get
                {
                    return _versaodetestesnaousaremproducaoInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The VersaoDeTestesNaoUsarEmProducao item info.
            /// </summary>
            [RepositoryItemInfo("76b1ac75-aa1d-49a6-99f4-8bd46c53ccbf")]
            public virtual RepoItemInfo VersaoDeTestesNaoUsarEmProducaoInfo
            {
                get
                {
                    return _versaodetestesnaousaremproducaoInfo;
                }
            }
        }

        /// <summary>
        /// The GeradorDeCPF4DevsGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("db1c7825-cfae-45d8-8ee4-2201be0a96b1")]
        public partial class GeradorDeCPF4DevsGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _paneInfo;

            /// <summary>
            /// Creates a new GeradorDeCPF4DevsGoogleChrome  folder.
            /// </summary>
            public GeradorDeCPF4DevsGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("GeradorDeCPF4DevsGoogleChrome", "/form[@title>'Gerador de CPF - 4Devs - Google']", parentFolder, 30000, null, true, "db1c7825-cfae-45d8-8ee4-2201be0a96b1", "")
            {
                _paneInfo = new RepoItemInfo(this, "Pane", "container[@accessiblename>'Gerador de CPF - 4Devs - Google']/container/container[2]/container[1]", 30000, null, "74a1d2cd-b0cb-4c36-9731-b860f4ebafe9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("db1c7825-cfae-45d8-8ee4-2201be0a96b1")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("db1c7825-cfae-45d8-8ee4-2201be0a96b1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Pane item.
            /// </summary>
            [RepositoryItem("74a1d2cd-b0cb-4c36-9731-b860f4ebafe9")]
            public virtual Ranorex.Container Pane
            {
                get
                {
                    return _paneInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Pane item info.
            /// </summary>
            [RepositoryItemInfo("74a1d2cd-b0cb-4c36-9731-b860f4ebafe9")]
            public virtual RepoItemInfo PaneInfo
            {
                get
                {
                    return _paneInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("3fce3ead-9b07-43c3-9e2d-3c7f6ba599f6")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _ranorexstudio1executandoowindowsInfo;
            RepoItemInfo _scvexeatalho21executandoowiInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "3fce3ead-9b07-43c3-9e2d-3c7f6ba599f6", "")
            {
                _ranorexstudio1executandoowindowsInfo = new RepoItemInfo(this, "RanorexStudio1ExecutandoOWindows", "container[@controlid='40965']//toolbar[@accessiblename='Aplicativos em execução']/button[16]", 30000, null, "504bf1d7-316f-42df-8d78-4b850655bc13");
                _scvexeatalho21executandoowiInfo = new RepoItemInfo(this, "SCVExeAtalho21ExecutandoOWi", "container[@controlid='40965']//toolbar[@accessiblename='Aplicativos em execução']/button[18]", 30000, null, "ec8138cd-1bd3-44ba-9cd2-251160080e48");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3fce3ead-9b07-43c3-9e2d-3c7f6ba599f6")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3fce3ead-9b07-43c3-9e2d-3c7f6ba599f6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RanorexStudio1ExecutandoOWindows item.
            /// </summary>
            [RepositoryItem("504bf1d7-316f-42df-8d78-4b850655bc13")]
            public virtual Ranorex.Button RanorexStudio1ExecutandoOWindows
            {
                get
                {
                    return _ranorexstudio1executandoowindowsInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RanorexStudio1ExecutandoOWindows item info.
            /// </summary>
            [RepositoryItemInfo("504bf1d7-316f-42df-8d78-4b850655bc13")]
            public virtual RepoItemInfo RanorexStudio1ExecutandoOWindowsInfo
            {
                get
                {
                    return _ranorexstudio1executandoowindowsInfo;
                }
            }

            /// <summary>
            /// The SCVExeAtalho21ExecutandoOWi item.
            /// </summary>
            [RepositoryItem("ec8138cd-1bd3-44ba-9cd2-251160080e48")]
            public virtual Ranorex.Button SCVExeAtalho21ExecutandoOWi
            {
                get
                {
                    return _scvexeatalho21executandoowiInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SCVExeAtalho21ExecutandoOWi item info.
            /// </summary>
            [RepositoryItemInfo("ec8138cd-1bd3-44ba-9cd2-251160080e48")]
            public virtual RepoItemInfo SCVExeAtalho21ExecutandoOWiInfo
            {
                get
                {
                    return _scvexeatalho21executandoowiInfo;
                }
            }
        }

        /// <summary>
        /// The FrmNotificacaoAppFolder folder.
        /// </summary>
        [RepositoryFolder("76663ef8-3302-4b66-931b-2481d1e6b828")]
        public partial class FrmNotificacaoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _mmomensagemInfo;
            RepoItemInfo _confirmaenterInfo;
            RepoItemInfo _cancelarescInfo;

            /// <summary>
            /// Creates a new FrmNotificacao  folder.
            /// </summary>
            public FrmNotificacaoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmNotificacao", "/form[@name='frmNotificacao']", parentFolder, 30000, null, true, "76663ef8-3302-4b66-931b-2481d1e6b828", "")
            {
                _mmomensagemInfo = new RepoItemInfo(this, "MmoMensagem", "?/?/text[@name='mmoMensagem']", 30000, null, "87df15dc-3ffb-4a68-97cd-1c4613f44dee");
                _confirmaenterInfo = new RepoItemInfo(this, "ConfirmaEnter", "?/?/button[@name='cxbtnConfirma']", 30000, null, "8fb71705-eebc-4d80-9016-5a383b2dafa7");
                _cancelarescInfo = new RepoItemInfo(this, "CancelarEsc", "?/?/button[@name='cxbtnCancela']", 30000, null, "73385121-059e-4a6a-bb94-ac796cd0cbc9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("76663ef8-3302-4b66-931b-2481d1e6b828")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("76663ef8-3302-4b66-931b-2481d1e6b828")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MmoMensagem item.
            /// </summary>
            [RepositoryItem("87df15dc-3ffb-4a68-97cd-1c4613f44dee")]
            public virtual Ranorex.Text MmoMensagem
            {
                get
                {
                    return _mmomensagemInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The MmoMensagem item info.
            /// </summary>
            [RepositoryItemInfo("87df15dc-3ffb-4a68-97cd-1c4613f44dee")]
            public virtual RepoItemInfo MmoMensagemInfo
            {
                get
                {
                    return _mmomensagemInfo;
                }
            }

            /// <summary>
            /// The ConfirmaEnter item.
            /// </summary>
            [RepositoryItem("8fb71705-eebc-4d80-9016-5a383b2dafa7")]
            public virtual Ranorex.Button ConfirmaEnter
            {
                get
                {
                    return _confirmaenterInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ConfirmaEnter item info.
            /// </summary>
            [RepositoryItemInfo("8fb71705-eebc-4d80-9016-5a383b2dafa7")]
            public virtual RepoItemInfo ConfirmaEnterInfo
            {
                get
                {
                    return _confirmaenterInfo;
                }
            }

            /// <summary>
            /// The CancelarEsc item.
            /// </summary>
            [RepositoryItem("73385121-059e-4a6a-bb94-ac796cd0cbc9")]
            public virtual Ranorex.Button CancelarEsc
            {
                get
                {
                    return _cancelarescInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The CancelarEsc item info.
            /// </summary>
            [RepositoryItemInfo("73385121-059e-4a6a-bb94-ac796cd0cbc9")]
            public virtual RepoItemInfo CancelarEscInfo
            {
                get
                {
                    return _cancelarescInfo;
                }
            }
        }

        /// <summary>
        /// The ConsultaCadastroDeCidadesAppFolder folder.
        /// </summary>
        [RepositoryFolder("e17fa419-9ee6-43b5-beaf-46a99e1ef168")]
        public partial class ConsultaCadastroDeCidadesAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ConsultaCadastroDeCidades  folder.
            /// </summary>
            public ConsultaCadastroDeCidadesAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ConsultaCadastroDeCidades", "/form[@name='frmF12Cidades']", parentFolder, 30000, null, true, "e17fa419-9ee6-43b5-beaf-46a99e1ef168", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e17fa419-9ee6-43b5-beaf-46a99e1ef168")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e17fa419-9ee6-43b5-beaf-46a99e1ef168")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
