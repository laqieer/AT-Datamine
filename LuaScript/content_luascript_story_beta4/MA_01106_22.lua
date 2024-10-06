-- このluaスクリプトは、MA_01106_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
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
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ケイ★★:カレドニア王ライエンスは狡猾だ
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01106_220002")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:自軍の被害を最小限に抑えつつ<br>我が王を討ちたいのだろう
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01106_220003")


	--★★トリスタン★★:魔女もいたし<br>それ以外にも何か目的があるのかもね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01106_220004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ブライアンは、俺を呼んでる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_220005")


	--★★ランスロット★★:なぜ…そう思う？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_220006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ブライアンは<br>「お目付け役の魔術師抜きで」と言っていた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_220007")


	--★★ノワール★★:アーサー王ひとりで来い<br>とは言っていない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_220008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:屁理屈だよ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01106_220009")


	--★★ノワール★★:機転は利くけど<br>ウソがうまい人間じゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_220010")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:…憎まれ口叩いてたのも<br>本心じゃねーってのか？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01106_220011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,0.7, 0.03, 0.7, 0.5)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★アーサー★★:じゃあ俺！やっぱちょっと行こうか！
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220012")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:アーサー…！
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_220013")

	change_face(Actor003,"Sad")

	--★★ガウェイン★★:ワナに決まってますよ！<br>死にに行くようなもんだ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01106_220014")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★アーサー★★:たまには王としての威厳を見せつけなければな<br>こう舐められては生徒たちに迷惑がかかる
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:それに、オレは不死身さあ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220017")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:モルガン様を<br>人質に取られた状態でもか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_220018")


	--★★アーサー★★:俺が行かねば助からない<br>ならば行って助けるしか道はあるまい？
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力

	--★★トリスタン★★:…確かに、それしかないね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01106_220020")


	--★★アーサー★★:生徒や国民の面倒は頼む<br>ランスロット、義兄さん
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220022")

	change_face(Actor006,"Sad")

	--★★ケイ★★:…くれぐれも<br>無茶はせんでくれよ
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01106_220023")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★アーサー★★:大丈夫だ<br>心強い護衛がいるからな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01106_220026","MA_01106_220027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろんだ<br>任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_220029")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:頼むぞ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_220030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺も着いてくぜ、ダチだからな！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01106_220031")

	change_face(Actor004,"Surprise")

	--★★トリスタン★★:…早すぎるでしょ、仲良くなるの
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01106_220032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:構わないが…<br>円卓会議にかけなくていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_220034")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:反対するヤツなんかいんのかよ<br>この状況で
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01106_220035")

	change_face(Actor004,"Normal")

	--★★トリスタン★★:さすがのボクも空気を読むよ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01106_220036")

	goto Block1end

::Block1end::
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★アーサー★★:決まりだな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220038")

	change_face(Actor005,"Smile")

	--★★アーサー★★:出発のX日後<br>それまでに準備を、抜かりなくな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_220039")

	open_cutin(1,1)
	on_cutin(1,Actor005,"Normal")

	--★★アーサー★★:スタンド・バイ・ユアラウンド
	Talk(Actor005,"CHRNAME_ARTHUR","speech","N","MA_01106_220040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	close_cutin()

	--★★一同★★:フォー・ラウンド！
	Talk(Actor007,"NPCNAME_0126","speech","N","MA_01106_220041")

-- ▼直接出力
wait_time(0.5)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★トリスタン★★:どんなふうになっても<br>気にかけずにはいられない
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01106_220043")

	change_face(Actor004,"Sad")

	--★★トリスタン★★:面倒だよね、家族って
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01106_220044")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
