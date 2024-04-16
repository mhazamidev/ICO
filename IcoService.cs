using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using TestAPI.Contracts.ICO.ContractDefinition;

namespace TestAPI.Contracts.ICO
{
    public partial class IcoService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IcoDeployment icoDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IcoDeployment>().SendRequestAndWaitForReceiptAsync(icoDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IcoDeployment icoDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IcoDeployment>().SendRequestAsync(icoDeployment);
        }

        public static async Task<IcoService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IcoDeployment icoDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, icoDeployment, cancellationTokenSource);
            return new IcoService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IcoService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public IcoService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> ActivateRequestAsync(ActivateFunction activateFunction)
        {
             return ContractHandler.SendRequestAsync(activateFunction);
        }

        public Task<TransactionReceipt> ActivateRequestAndWaitForReceiptAsync(ActivateFunction activateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(activateFunction, cancellationToken);
        }

        public Task<string> ActivateRequestAsync(BigInteger duration)
        {
            var activateFunction = new ActivateFunction();
                activateFunction.Duration = duration;
            
             return ContractHandler.SendRequestAsync(activateFunction);
        }

        public Task<TransactionReceipt> ActivateRequestAndWaitForReceiptAsync(BigInteger duration, CancellationTokenSource cancellationToken = null)
        {
            var activateFunction = new ActivateFunction();
                activateFunction.Duration = duration;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(activateFunction, cancellationToken);
        }

        public Task<string> AdminQueryAsync(AdminFunction adminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AdminFunction, string>(adminFunction, blockParameter);
        }

        
        public Task<string> AdminQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AdminFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> AirDropAmountQueryAsync(AirDropAmountFunction airDropAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AirDropAmountFunction, BigInteger>(airDropAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> AirDropAmountQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AirDropAmountFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> AirdropRequestAsync(AirdropFunction airdropFunction)
        {
             return ContractHandler.SendRequestAsync(airdropFunction);
        }

        public Task<TransactionReceipt> AirdropRequestAndWaitForReceiptAsync(AirdropFunction airdropFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(airdropFunction, cancellationToken);
        }

        public Task<string> AirdropRequestAsync(string receiver)
        {
            var airdropFunction = new AirdropFunction();
                airdropFunction.Receiver = receiver;
            
             return ContractHandler.SendRequestAsync(airdropFunction);
        }

        public Task<TransactionReceipt> AirdropRequestAndWaitForReceiptAsync(string receiver, CancellationTokenSource cancellationToken = null)
        {
            var airdropFunction = new AirdropFunction();
                airdropFunction.Receiver = receiver;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(airdropFunction, cancellationToken);
        }

        public Task<BigInteger> AirdropsQueryAsync(AirdropsFunction airdropsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AirdropsFunction, BigInteger>(airdropsFunction, blockParameter);
        }

        
        public Task<BigInteger> AirdropsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var airdropsFunction = new AirdropsFunction();
                airdropsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<AirdropsFunction, BigInteger>(airdropsFunction, blockParameter);
        }

        public Task<BigInteger> BalanceOfETHQueryAsync(BalanceOfETHFunction balanceOfETHFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfETHFunction, BigInteger>(balanceOfETHFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfETHQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var balanceOfETHFunction = new BalanceOfETHFunction();
                balanceOfETHFunction.Account = account;
            
            return ContractHandler.QueryAsync<BalanceOfETHFunction, BigInteger>(balanceOfETHFunction, blockParameter);
        }

        public Task<BigInteger> BalanceOfTokenQueryAsync(BalanceOfTokenFunction balanceOfTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfTokenFunction, BigInteger>(balanceOfTokenFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfTokenQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var balanceOfTokenFunction = new BalanceOfTokenFunction();
                balanceOfTokenFunction.Account = account;
            
            return ContractHandler.QueryAsync<BalanceOfTokenFunction, BigInteger>(balanceOfTokenFunction, blockParameter);
        }

        public Task<string> DepositTokensRequestAsync(DepositTokensFunction depositTokensFunction)
        {
             return ContractHandler.SendRequestAsync(depositTokensFunction);
        }

        public Task<TransactionReceipt> DepositTokensRequestAndWaitForReceiptAsync(DepositTokensFunction depositTokensFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositTokensFunction, cancellationToken);
        }

        public Task<string> DepositTokensRequestAsync(BigInteger amount)
        {
            var depositTokensFunction = new DepositTokensFunction();
                depositTokensFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(depositTokensFunction);
        }

        public Task<TransactionReceipt> DepositTokensRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var depositTokensFunction = new DepositTokensFunction();
                depositTokensFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositTokensFunction, cancellationToken);
        }

        public Task<string> GetICOAddressQueryAsync(GetICOAddressFunction getICOAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetICOAddressFunction, string>(getICOAddressFunction, blockParameter);
        }

        
        public Task<string> GetICOAddressQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetICOAddressFunction, string>(null, blockParameter);
        }

        public Task<string> GetTokenAddressQueryAsync(GetTokenAddressFunction getTokenAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTokenAddressFunction, string>(getTokenAddressFunction, blockParameter);
        }

        
        public Task<string> GetTokenAddressQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTokenAddressFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> HoldersQueryAsync(HoldersFunction holdersFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HoldersFunction, BigInteger>(holdersFunction, blockParameter);
        }

        
        public Task<BigInteger> HoldersQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var holdersFunction = new HoldersFunction();
                holdersFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<HoldersFunction, BigInteger>(holdersFunction, blockParameter);
        }

        public Task<BigInteger> HoldersCountQueryAsync(HoldersCountFunction holdersCountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HoldersCountFunction, BigInteger>(holdersCountFunction, blockParameter);
        }

        
        public Task<BigInteger> HoldersCountQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HoldersCountFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> IcoEndTimeQueryAsync(IcoEndTimeFunction icoEndTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IcoEndTimeFunction, BigInteger>(icoEndTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> IcoEndTimeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IcoEndTimeFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> InactivateRequestAsync(InactivateFunction inactivateFunction)
        {
             return ContractHandler.SendRequestAsync(inactivateFunction);
        }

        public Task<string> InactivateRequestAsync()
        {
             return ContractHandler.SendRequestAsync<InactivateFunction>();
        }

        public Task<TransactionReceipt> InactivateRequestAndWaitForReceiptAsync(InactivateFunction inactivateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(inactivateFunction, cancellationToken);
        }

        public Task<TransactionReceipt> InactivateRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<InactivateFunction>(null, cancellationToken);
        }

        public Task<bool> IsInListQueryAsync(IsInListFunction isInListFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInListFunction, bool>(isInListFunction, blockParameter);
        }

        
        public Task<bool> IsInListQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isInListFunction = new IsInListFunction();
                isInListFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsInListFunction, bool>(isInListFunction, blockParameter);
        }

        public Task<BigInteger> MaxAirdropAmountQueryAsync(MaxAirdropAmountFunction maxAirdropAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxAirdropAmountFunction, BigInteger>(maxAirdropAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> MaxAirdropAmountQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxAirdropAmountFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> PurchaseRequestAsync(PurchaseFunction purchaseFunction)
        {
             return ContractHandler.SendRequestAsync(purchaseFunction);
        }

        public Task<TransactionReceipt> PurchaseRequestAndWaitForReceiptAsync(PurchaseFunction purchaseFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(purchaseFunction, cancellationToken);
        }

        public Task<string> PurchaseRequestAsync(BigInteger amount)
        {
            var purchaseFunction = new PurchaseFunction();
                purchaseFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(purchaseFunction);
        }

        public Task<TransactionReceipt> PurchaseRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var purchaseFunction = new PurchaseFunction();
                purchaseFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(purchaseFunction, cancellationToken);
        }

        public Task<string> TokenQueryAsync(TokenFunction tokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenFunction, string>(tokenFunction, blockParameter);
        }

        
        public Task<string> TokenQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> TokenPriceQueryAsync(TokenPriceFunction tokenPriceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenPriceFunction, BigInteger>(tokenPriceFunction, blockParameter);
        }

        
        public Task<BigInteger> TokenPriceQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenPriceFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> TotalReleasedAirdropQueryAsync(TotalReleasedAirdropFunction totalReleasedAirdropFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalReleasedAirdropFunction, BigInteger>(totalReleasedAirdropFunction, blockParameter);
        }

        
        public Task<BigInteger> TotalReleasedAirdropQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalReleasedAirdropFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> UpdateAdminRequestAsync(UpdateAdminFunction updateAdminFunction)
        {
             return ContractHandler.SendRequestAsync(updateAdminFunction);
        }

        public Task<TransactionReceipt> UpdateAdminRequestAndWaitForReceiptAsync(UpdateAdminFunction updateAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateAdminFunction, cancellationToken);
        }

        public Task<string> UpdateAdminRequestAsync(string newAdmin)
        {
            var updateAdminFunction = new UpdateAdminFunction();
                updateAdminFunction.NewAdmin = newAdmin;
            
             return ContractHandler.SendRequestAsync(updateAdminFunction);
        }

        public Task<TransactionReceipt> UpdateAdminRequestAndWaitForReceiptAsync(string newAdmin, CancellationTokenSource cancellationToken = null)
        {
            var updateAdminFunction = new UpdateAdminFunction();
                updateAdminFunction.NewAdmin = newAdmin;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateAdminFunction, cancellationToken);
        }

        public Task<string> WithdrawETHRequestAsync(WithdrawETHFunction withdrawETHFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawETHFunction);
        }

        public Task<TransactionReceipt> WithdrawETHRequestAndWaitForReceiptAsync(WithdrawETHFunction withdrawETHFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFunction, cancellationToken);
        }

        public Task<string> WithdrawETHRequestAsync(BigInteger amount)
        {
            var withdrawETHFunction = new WithdrawETHFunction();
                withdrawETHFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(withdrawETHFunction);
        }

        public Task<TransactionReceipt> WithdrawETHRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdrawETHFunction = new WithdrawETHFunction();
                withdrawETHFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFunction, cancellationToken);
        }

        public Task<string> WithdrawTokensRequestAsync(WithdrawTokensFunction withdrawTokensFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawTokensFunction);
        }

        public Task<TransactionReceipt> WithdrawTokensRequestAndWaitForReceiptAsync(WithdrawTokensFunction withdrawTokensFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawTokensFunction, cancellationToken);
        }

        public Task<string> WithdrawTokensRequestAsync(BigInteger amount)
        {
            var withdrawTokensFunction = new WithdrawTokensFunction();
                withdrawTokensFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(withdrawTokensFunction);
        }

        public Task<TransactionReceipt> WithdrawTokensRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdrawTokensFunction = new WithdrawTokensFunction();
                withdrawTokensFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawTokensFunction, cancellationToken);
        }
    }
}
