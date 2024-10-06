Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★リアム★★:おや、ノワールさん<br>いかがなさいましたか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010001")
	CloseTalkWindow()

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101064_00010003","CO_101064_00010004")
	CloseTalkWindow()

	if is_select(1) then

		--★★リアム★★:私と？…そうですね<br>散歩程度ならお付き合いしましょう
		Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010005")

		local locations = commu.GetLocations() -- GetLocations()※複数形
		if communication_place_select(locations) then -- ロケーション選択

			--★★リアム★★:ほう…良い選択ですね
			Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010007")
		else
			--★★リアム★★:そうですか<br>では、良い一日を
			Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010006")

			system.Cancel()
		end

	elseif is_select(2) then

		--★★リアム★★:そうですか<br>では、良い一日を
		Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_00010006")

		system.Cancel()
	else
		-- 例外処理
		system.Cancel()
	end

	-- メイン処理はここまで。システム側が普通ロケーションlua、もしくは好みロケーションluaを再生します。
	EndPlayActive()
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end
