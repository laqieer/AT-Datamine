-- このluaスクリプトは、MA_01B112_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor009)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor011)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:すべてが順調だ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_390002")


	--★★ケイ★★:此度の遠征…大戦果ではないか<br>無事にギネヴィア王妃とマーリンを救出できた
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_390004")


	--★★ケイ★★:あわせて聖杯を狙う魔女を掃討し<br>銀卓騎士団を退けられたことも大きい
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_390005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ケイ★★:なにより、無事帰って来てくれたことを<br>嬉しく思う
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B112_390007")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ボールス★★:…ガウェインたちの活躍で<br>ローマの残党兵もほぼ片付けられたと聞く
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B112_390008")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ボールス★★:これで後顧の憂いは断てた
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B112_390009")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力

	--★★パーシヴァル★★:聖杯もノワールの手にあるわけだし<br>ボクらの大願成就も近い…ってことだね
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_390012","MA_01B112_390013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この地からバルバロイを根絶しよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_390015")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★パーシヴァル★★:乗りかかった船だからね<br>最後まで付き合ってあげるよ
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390016")

	change_face(Actor006,"Normal")

	--★★ボールス★★:いつになく素直だな
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B112_390017")

	change_face(Actor005,"Normal")

	--★★パーシヴァル★★:高貴な者として<br>頭を下げての願いを断るわけにはいかないだけだよ
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390018")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★パーシヴァル★★:それに…船長の覚悟を目の当たりにしたらね
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:待ちわびた平和が来る<br>それでいい、それこそがいいじゃないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390021")

	change_face(Actor005,"Sad")

	--★★パーシヴァル★★:ランスロット<br>感服するよ…キミには
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390022")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ボールス★★:気を強く持ち続けていたのだな<br>今まで、ずっと
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B112_390023")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ランスロット★★:『聖域化』がなされれば<br>無限に増え続けるバルバロイの脅威は去る
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:誰もが望んだ平和が訪れる<br>あと、少しだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390026")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★パーシヴァル★★:………聖杯を使えばバルバロイの大ボスが現れて<br>それを倒せば、全部終わり…なんだっけ？
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★パーシヴァル★★:だったらさぁ…まあ、なんというか<br>もうちょっとだけでも待てないものかなあ
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390028")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ボールス★★:…ブリテンではバルバロイが増え続けている<br>悠長なことを言っている場合ではないが…
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B112_390029")

	change_face(Actor005,"Sad")

	--★★パーシヴァル★★:けど、だけどこんなの残酷だ<br>心の準備とか、そのぐらいの時間は──
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01B112_390030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:心は決まっている<br>最初から決まっていたことだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390031")


	--★★ランスロット★★:『最強騎士』など要らない世界が訪れる<br>戦いを強いられる日々などなくせる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390032")


	--★★ランスロット★★:願ってもいないことだ<br>この学園を守れるのなら
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:………降誕祭は、あるのか？
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B112_390035")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:無論だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_390036")

	change_face(Actor001,"Sad")

	--★★ノワール★★:その時間は………あるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_390037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:…もちろんだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_390038")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力

	--★★ガラハッド★★:功労者の欠席は<br>許されないだろう？
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B112_390039")

	change_face(Actor003,"Smile")

	--★★アーサー★★:当然強制参加だ。ランス
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_390041")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力

	--★★ランスロット★★:………まいったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390042")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:離れがたくなるじゃないか。ますます
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_390044")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
