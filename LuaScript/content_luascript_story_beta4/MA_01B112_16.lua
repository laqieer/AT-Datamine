-- このluaスクリプトは、MA_01B112_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_003)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112031)
	Actor001 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:耳障りでしょう？<br>仕事の音は
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160002")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リリアーナ★★:い、いいえ…<br>いっぱい人がいる所より、ぜんぜん…！
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160003")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力

	--★★ボールス★★:かしましいヤツがいるが？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B112_160004")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★リリアーナ★★:…どこから監視されているかビクビクするより<br>いいですから…
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160006")


	--★★クレア★★:これ、皮肉？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160007")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ボールス★★:………臆病さをこじらせているな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B112_160008")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor001,Camera001,EntryData112031_01_06,CameraAssetBundleName112031_01,CameraPos112031_01_106)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,181.5,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ガラハッド★★:こんにちは
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:こ、こんにちは…
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160011")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:騒がしくなりそうね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160012")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力

	--★★ガラハッド★★:もうグズらないぞ。リリアーナ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160013")


	--★★リリアーナ★★:…コルベニック城に帰るの？<br>ガラハッド
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160014")

-- ▼直接出力
setup_small_camera_end()
bgm_play("BGM_ADV_Speculation")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ガラハッド★★:なぜ銀卓騎士団やお爺様は<br>アーサー王を狙う？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★リリアーナ★★:ペレス王の言いつけどおり<br>逃げ出したっていいんですよ…？
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160017")


	--★★ガラハッド★★:最強騎士を護るのはかつての恩義のためだろう<br>だが彼らの王を討とうとはどういう道理だ？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160018")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:…どうして歯向かおうとするのです？<br>少しでも生き延びる道を探すべきなのに
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160020")

	PlayAction(Actor001,"to  Std_No")

	--★★ガラハッド★★:質問しているのはこっちだ。答えろ<br>お前にはまだ聞きたいことがほかにもある
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160021")


	--★★ガラハッド★★:お爺様を貫いた理由<br>それも吐いてもらわなければならない
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:「穢れた血を絶やせ」と<br>ペレス王は述べていた
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クレア★★:『穢れた血』…<br>それがアーサー王のことを指すのかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160026")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★リリアーナ★★:か、かえります…
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160027")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("クレア", "否定")
-- ▲直接出力

	--★★クレア★★:『血』──アーサーの血縁？血族？<br>誰かしらが穢された…ということかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★クレア★★:王家の秘密？先代に遡る罪？<br>明かせば大きな影響力があるような何かが？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160030")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★リリアーナ★★:知らなくて…いいことです
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160032")


	--★★ガラハッド★★:隠すのはガラハッドたちのためか？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160033")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★リリアーナ★★:銀卓の責務のためです
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160034")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ガラハッド★★:姉上は悩みをガラハッドに伝えず<br>抱え込んでいた
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160035")


	--★★ガラハッド★★:お前も同じ目をしてる<br>悪意とは違う輝きの目だ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_160036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")

	--★★リリアーナ★★:………
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160037")

	change_face(Actor002,"Sad")

	--★★クレア★★:前に罪滅ぼしをしたいと言っていたわね<br>それはなんの罪なのかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B112_160038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力

	--★★リリアーナ★★:………もちろん
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★リリアーナ★★:王殺しの、です
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_160041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Speculation")
	InitializeLoad_Preload()
	load_area_scene_preload(112031)
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
