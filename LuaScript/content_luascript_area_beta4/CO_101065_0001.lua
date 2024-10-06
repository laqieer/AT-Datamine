Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★キッス★★:ラビットちゃんじゃな～い<br>どうしたの？アタシに用事？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010001")
	CloseTalkWindow()

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101065_00010003","CO_101065_00010004")
	CloseTalkWindow()

	if is_select(1) then

		--★★キッス★★:あら、デートのお誘いね？
		Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010005")

		local locations = commu.GetLocations() -- GetLocations()※複数形
		if communication_place_select(locations) then -- ロケーション選択

			--★★キッス★★:いいわよ～♪
			Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010007")
		else
			--★★キッス★★:つれないのね～<br>ざ～んねん
			Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010006")

			system.Cancel()
		end

	elseif is_select(2) then

		--★★キッス★★:つれないのね～<br>ざ～んねん
		Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_00010006")

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
	InitializeActiveCharacter_Preload("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end
