-- このluaスクリプトは、CO_101022_1001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")

	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")

	set_pos(Actor003, {-15+1, 0.01-3, 7.3})	-- 一旦画面外に配置
	set_animationcontroller_path(Actor003, "content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop")
	set_pos(Actor004, {0.8, 0.01-3, -1.1})	-- 一旦画面外に配置
	set_animationcontroller_path(Actor004, "content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop")

	off_active(Actor003)
	off_active(Actor004)

end

function Play()
	StartPlayActive()

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:よお、ノワール/いいところにきたな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010003")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101022_10010005","CO_101022_10010006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:その顔…/もしかして黒幕が見つかったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10010008")

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:ああ/釣れたぜ、見事にな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ケリをつけにいこうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10010011")

	change_face(Actor003,"Normal")

	--★★クラリス★★:ま、まってくださ～～い！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10010013")

	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:あ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010014")


	CloseTalkWindow()

	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

	-- 食堂前広場用配置
	set_pos(Actor003, {-15+1, 0.01, 7.3})
	set_rot(Actor003, {0, -90, 0})
	on_active(Actor003)

	-- ログレス中央マーケット用配置
	set_pos(Actor004, {0.8, 0.01, -1.1})
	set_rot(Actor004, {0, 90, 0})
	on_active(Actor004)

	fadein(CHARA_IN_OUT)
	wait_time(CHARA_IN_OUT)


	change_face(Actor003,"Sad")

	--★★クラリス★★:わ、わたしも！わたしも行きます…！/連れてってください…！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10010016")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？あ、ああ…/俺は別に構わないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10010017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どうする？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10010019")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:相手はバルバロイじゃねえんだ/連れていくほうがおかしいだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010020")

	change_face(Actor003,"Anger")

	--★★クラリス★★:やです！！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10010021")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:あ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010022")

	change_face(Actor003,"Sad")

	--★★クラリス★★:やだ…連れてって、モルくん…！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10010023")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:んだよ/いつもなら大人しく大聖堂に籠るクセに
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010025")

	change_face(Actor003,"Sad")

	--★★クラリス★★:だ、だってぇ～…/今日はどうしても、行かなきゃって…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10010027")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:あー、わかったわかった/なら勝手に着いて来い
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010029")

	change_face(Actor003,"Smile")

	--★★クラリス★★:やったぁ～～！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10010031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:えーっと…/話が付いたなら、行くか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10010032")

	change_face(Actor003,"Smile")

	--★★クラリス★★:はい～！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10010034")

	change_face(Actor002,"Sad")

	--★★モルドレッド★★:チッ、しゃーねえな…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010036")

	reserve_next_script("1章/コミュ/x0401_モルドレッド_ランクアップ10_2")

	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10010038")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:さっさと済ませて来いよ/やんなきゃなんねえコトがあんだからよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10010039")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive()

	kill(Actor003)	-- 念のため追加登録したキャラをデモ終了時に破棄
	kill(Actor004)	-- 念のため追加登録したキャラをデモ終了時に破棄

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
	InitializeActiveCharacter_Preload("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
end
