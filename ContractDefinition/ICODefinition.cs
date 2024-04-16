using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace TestAPI.Contracts.ICO.ContractDefinition
{


    public partial class IcoDeployment : IcoDeploymentBase
    {
        public IcoDeployment() : base(BYTECODE) { }
        public IcoDeployment(string byteCode) : base(byteCode) { }
    }

    public class IcoDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405266038d7ea4c6800060025568056bc75e2d6310000060035569d3c21bcecceda10000006005553480156034575f80fd5b50604051610e22380380610e22833981016040819052605191609d565b5f80546001600160a01b039283166001600160a01b0319918216179091556001805493909216921691909117905560c9565b80516001600160a01b03811681146098575f80fd5b919050565b5f806040838503121560ad575f80fd5b60b4836083565b915060c0602084016083565b90509250929050565b610d4c806100d65f395ff3fe60806040526004361061013c575f3560e01c80638c86f0a7116100b3578063e2f273bd1161006d578063e2f273bd14610342578063efef39a114610361578063f14210a614610374578063f851a44014610393578063fa33bcf3146103b1578063fc0c546a146103ef575f80fd5b80638c86f0a714610291578063b260c42a146102bc578063b99152d0146102db578063d27289f2146102fa578063d82c6df41461030f578063dd49756e14610323575f80fd5b8063315a095d11610104578063315a095d146101fa578063561cd462146102195780636b4ed21b1461024057806375013a22146102555780637e1055b6146102675780637ff9b5961461027c575f80fd5b806308e9988b1461014057806310fe9ae81461016857806318a5bbdc1461019957806321860a05146101c457806323efeb12146101e5575b5f80fd5b34801561014b575f80fd5b5061015560035481565b6040519081526020015b60405180910390f35b348015610173575f80fd5b506001546001600160a01b03165b6040516001600160a01b03909116815260200161015f565b3480156101a4575f80fd5b506101556101b3366004610bb9565b60096020525f908152604090205481565b3480156101cf575f80fd5b506101e36101de366004610bb9565b61040e565b005b3480156101f0575f80fd5b5061015560055481565b348015610205575f80fd5b506101e3610214366004610be6565b610713565b348015610224575f80fd5b50610155610233366004610bb9565b6001600160a01b03163190565b34801561024b575f80fd5b5061015560075481565b348015610260575f80fd5b5030610181565b348015610272575f80fd5b5061015560065481565b348015610287575f80fd5b5061015560025481565b34801561029c575f80fd5b506101556102ab366004610bb9565b60086020525f908152604090205481565b3480156102c7575f80fd5b506101e36102d6366004610be6565b6107b5565b3480156102e6575f80fd5b506101556102f5366004610bb9565b61083d565b348015610305575f80fd5b5061015560045481565b34801561031a575f80fd5b506101e36108af565b34801561032e575f80fd5b506101e361033d366004610be6565b610932565b34801561034d575f80fd5b506101e361035c366004610bb9565b61099b565b6101e361036f366004610be6565b6109e5565b34801561037f575f80fd5b506101e361038e366004610be6565b610b62565b34801561039e575f80fd5b505f54610181906001600160a01b031681565b3480156103bc575f80fd5b506103df6103cb366004610bb9565b600a6020525f908152604090205460ff1681565b604051901515815260200161015f565b3480156103fa575f80fd5b50600154610181906001600160a01b031681565b5f600654118015610420575060065442105b6104675760405162461bcd60e51b81526020600482015260136024820152721250d3c81a185d99481899595b88195b991959606a1b60448201526064015b60405180910390fd5b6001600160a01b0381165f90815260086020526040902054156104c55760405162461bcd60e51b815260206004820152601660248201527561697264726f703a20616c726561647920646f6e652160501b604482015260640161045e565b6005546003546004546104d89190610c11565b11156105395760405162461bcd60e51b815260206004820152602a60248201527f61697264726f703a20616c6c2061697264726f7020746f6b656e7320776572656044820152692072656c65617365642160b01b606482015260840161045e565b6003546105453061083d565b10156105a25760405162461bcd60e51b815260206004820152602660248201527f61697264726f703a204e6f20656e6f75676820746f6b656e7320666f722061696044820152657264726f702160d01b606482015260840161045e565b60015460035460405163a9059cbb60e01b81526001600160a01b038481166004830152602482019290925291169063a9059cbb906044016020604051808303815f875af11580156105f5573d5f803e3d5ffd5b505050506040513d601f19601f820116820180604052508101906106199190610c24565b506003546001600160a01b0382165f90815260086020526040812082905560048054909190610649908490610c11565b90915550506003546040516001600160a01b038316907f8c32c568416fcf97be35ce5b27844cfddcd63a67a1a602c3595ba5dac38f303a905f90a36001600160a01b0381165f908152600a602052604090205460ff166106e1576001600160a01b0381165f908152600a60205260408120805460ff1916600190811790915560078054919290916106db908490610c11565b90915550505b6003546001600160a01b0382165f908152600960205260408120805490919061070b908490610c11565b909155505050565b61071c3061083d565b81111561073b5760405162461bcd60e51b815260040161045e90610c43565b6001545f5460405163a9059cbb60e01b81526001600160a01b0391821660048201526024810184905291169063a9059cbb906044015b6020604051808303815f875af115801561078d573d5f803e3d5ffd5b505050506040513d601f19601f820116820180604052508101906107b19190610c24565b5050565b5f546001600160a01b031633146107de5760405162461bcd60e51b815260040161045e90610c88565b5f811161082d5760405162461bcd60e51b815260206004820152601f60248201527f6475726174696f6e206d7573742062652067726561746572207468616e203000604482015260640161045e565b6108378142610c11565b60065550565b6001546040516370a0823160e01b81526001600160a01b0383811660048301525f9216906370a0823190602401602060405180830381865afa158015610885573d5f803e3d5ffd5b505050506040513d601f19601f820116820180604052508101906108a99190610cc9565b92915050565b5f546001600160a01b031633146108d85760405162461bcd60e51b815260040161045e90610c88565b5f6006541180156108ea575060065442105b61092c5760405162461bcd60e51b81526020600482015260136024820152721250d3c81a185d99481899595b88195b991959606a1b604482015260640161045e565b5f600655565b5f546001600160a01b0316331461095b5760405162461bcd60e51b815260040161045e90610c88565b6001545f546040516323b872dd60e01b81526001600160a01b039182166004820152306024820152604481018490529116906323b872dd90606401610771565b5f546001600160a01b031633146109c45760405162461bcd60e51b815260040161045e90610c88565b5f80546001600160a01b0319166001600160a01b0392909216919091179055565b6002546109fa670de0b6b3a764000083610ce0565b610a049190610cff565b3414610a525760405162461bcd60e51b815260206004820152601c60248201527f70757263686173653a206e6f7420636f72726563742076616c75652100000000604482015260640161045e565b60015460405163a9059cbb60e01b8152336004820152602481018390526001600160a01b039091169063a9059cbb906044016020604051808303815f875af1158015610aa0573d5f803e3d5ffd5b505050506040513d601f19601f82011682018060405250810190610ac49190610c24565b50335f908152600a602052604090205460ff16610b1057335f908152600a60205260408120805460ff191660019081179091556007805491929091610b0a908490610c11565b90915550505b335f9081526009602052604081208054839290610b2e908490610c11565b9091555050604051819033907fe3d4187f6ca4248660cc0ac8b8056515bac4a8132be2eca31d6d0cc170722a7e905f90a350565b3031811115610b835760405162461bcd60e51b815260040161045e90610c43565b5f80546040516001600160a01b039091169183156108fc02918491818181858888f193505050501580156107b1573d5f803e3d5ffd5b5f60208284031215610bc9575f80fd5b81356001600160a01b0381168114610bdf575f80fd5b9392505050565b5f60208284031215610bf6575f80fd5b5035919050565b634e487b7160e01b5f52601160045260245ffd5b808201808211156108a9576108a9610bfd565b5f60208284031215610c34575f80fd5b81518015158114610bdf575f80fd5b60208082526025908201527f74686520616d6f756e7420697320686967686572207468616e207468652062616040820152646c616e636560d81b606082015260800190565b60208082526021908201527f6f6e6c792061646d696e2063616e2063616c6c20746869732066756e6374696f6040820152603760f91b606082015260800190565b5f60208284031215610cd9575f80fd5b5051919050565b5f82610cfa57634e487b7160e01b5f52601260045260245ffd5b500490565b80820281158282048414176108a9576108a9610bfd56fea26469706673582212208640a8abc2043f41ab048f42327c090f7201f3a93a32e7373925c5a3264f138b64736f6c63430008190033";
        public IcoDeploymentBase() : base(BYTECODE) { }
        public IcoDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_token", 1)]
        public virtual string Token { get; set; }
        [Parameter("address", "_admin", 2)]
        public virtual string Admin { get; set; }
    }

    public partial class ActivateFunction : ActivateFunctionBase { }

    [Function("activate")]
    public class ActivateFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "duration", 1)]
        public virtual BigInteger Duration { get; set; }
    }

    public partial class AdminFunction : AdminFunctionBase { }

    [Function("admin", "address")]
    public class AdminFunctionBase : FunctionMessage
    {

    }

    public partial class AirDropAmountFunction : AirDropAmountFunctionBase { }

    [Function("airDropAmount", "uint256")]
    public class AirDropAmountFunctionBase : FunctionMessage
    {

    }

    public partial class AirdropFunction : AirdropFunctionBase { }

    [Function("airdrop")]
    public class AirdropFunctionBase : FunctionMessage
    {
        [Parameter("address", "_receiver", 1)]
        public virtual string Receiver { get; set; }
    }

    public partial class AirdropsFunction : AirdropsFunctionBase { }

    [Function("airdrops", "uint256")]
    public class AirdropsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class BalanceOfETHFunction : BalanceOfETHFunctionBase { }

    [Function("balanceOfETH", "uint256")]
    public class BalanceOfETHFunctionBase : FunctionMessage
    {
        [Parameter("address", "_account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class BalanceOfTokenFunction : BalanceOfTokenFunctionBase { }

    [Function("balanceOfToken", "uint256")]
    public class BalanceOfTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class DepositTokensFunction : DepositTokensFunctionBase { }

    [Function("depositTokens")]
    public class DepositTokensFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class GetICOAddressFunction : GetICOAddressFunctionBase { }

    [Function("getICOAddress", "address")]
    public class GetICOAddressFunctionBase : FunctionMessage
    {

    }

    public partial class GetTokenAddressFunction : GetTokenAddressFunctionBase { }

    [Function("getTokenAddress", "address")]
    public class GetTokenAddressFunctionBase : FunctionMessage
    {

    }

    public partial class HoldersFunction : HoldersFunctionBase { }

    [Function("holders", "uint256")]
    public class HoldersFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class HoldersCountFunction : HoldersCountFunctionBase { }

    [Function("holdersCount", "uint256")]
    public class HoldersCountFunctionBase : FunctionMessage
    {

    }

    public partial class IcoEndTimeFunction : IcoEndTimeFunctionBase { }

    [Function("icoEndTime", "uint256")]
    public class IcoEndTimeFunctionBase : FunctionMessage
    {

    }

    public partial class InactivateFunction : InactivateFunctionBase { }

    [Function("inactivate")]
    public class InactivateFunctionBase : FunctionMessage
    {

    }

    public partial class IsInListFunction : IsInListFunctionBase { }

    [Function("isInList", "bool")]
    public class IsInListFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MaxAirdropAmountFunction : MaxAirdropAmountFunctionBase { }

    [Function("maxAirdropAmount", "uint256")]
    public class MaxAirdropAmountFunctionBase : FunctionMessage
    {

    }

    public partial class PurchaseFunction : PurchaseFunctionBase { }

    [Function("purchase")]
    public class PurchaseFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TokenFunction : TokenFunctionBase { }

    [Function("token", "address")]
    public class TokenFunctionBase : FunctionMessage
    {

    }

    public partial class TokenPriceFunction : TokenPriceFunctionBase { }

    [Function("tokenPrice", "uint256")]
    public class TokenPriceFunctionBase : FunctionMessage
    {

    }

    public partial class TotalReleasedAirdropFunction : TotalReleasedAirdropFunctionBase { }

    [Function("totalReleasedAirdrop", "uint256")]
    public class TotalReleasedAirdropFunctionBase : FunctionMessage
    {

    }

    public partial class UpdateAdminFunction : UpdateAdminFunctionBase { }

    [Function("updateAdmin")]
    public class UpdateAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "_newAdmin", 1)]
        public virtual string NewAdmin { get; set; }
    }

    public partial class WithdrawETHFunction : WithdrawETHFunctionBase { }

    [Function("withdrawETH")]
    public class WithdrawETHFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class WithdrawTokensFunction : WithdrawTokensFunctionBase { }

    [Function("withdrawTokens")]
    public class WithdrawTokensFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class AirdropEventDTO : AirdropEventDTOBase { }

    [Event("Airdrop")]
    public class AirdropEventDTOBase : IEventDTO
    {
        [Parameter("address", "Receiver_address", 1, true )]
        public virtual string ReceiverAddress { get; set; }
        [Parameter("uint256", "amount", 2, true )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BuyEventDTO : BuyEventDTOBase { }

    [Event("Buy")]
    public class BuyEventDTOBase : IEventDTO
    {
        [Parameter("address", "buyer_address", 1, true )]
        public virtual string BuyerAddress { get; set; }
        [Parameter("uint256", "amount", 2, true )]
        public virtual BigInteger Amount { get; set; }
    }



    public partial class AdminOutputDTO : AdminOutputDTOBase { }

    [FunctionOutput]
    public class AdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class AirDropAmountOutputDTO : AirDropAmountOutputDTOBase { }

    [FunctionOutput]
    public class AirDropAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class AirdropsOutputDTO : AirdropsOutputDTOBase { }

    [FunctionOutput]
    public class AirdropsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BalanceOfETHOutputDTO : BalanceOfETHOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfETHOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BalanceOfTokenOutputDTO : BalanceOfTokenOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class GetICOAddressOutputDTO : GetICOAddressOutputDTOBase { }

    [FunctionOutput]
    public class GetICOAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetTokenAddressOutputDTO : GetTokenAddressOutputDTOBase { }

    [FunctionOutput]
    public class GetTokenAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class HoldersOutputDTO : HoldersOutputDTOBase { }

    [FunctionOutput]
    public class HoldersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class HoldersCountOutputDTO : HoldersCountOutputDTOBase { }

    [FunctionOutput]
    public class HoldersCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IcoEndTimeOutputDTO : IcoEndTimeOutputDTOBase { }

    [FunctionOutput]
    public class IcoEndTimeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class IsInListOutputDTO : IsInListOutputDTOBase { }

    [FunctionOutput]
    public class IsInListOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class MaxAirdropAmountOutputDTO : MaxAirdropAmountOutputDTOBase { }

    [FunctionOutput]
    public class MaxAirdropAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class TokenOutputDTO : TokenOutputDTOBase { }

    [FunctionOutput]
    public class TokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenPriceOutputDTO : TokenPriceOutputDTOBase { }

    [FunctionOutput]
    public class TokenPriceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TotalReleasedAirdropOutputDTO : TotalReleasedAirdropOutputDTOBase { }

    [FunctionOutput]
    public class TotalReleasedAirdropOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }






}
