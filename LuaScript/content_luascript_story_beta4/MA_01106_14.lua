-- このluaスクリプトは、MA_01106_14.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101160011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力

set_pos(Actor003,{3, 0, -3,})
set_pos(Actor004,{4, 0, -2})
set_pos(Actor002,{2, 0, -1.5})
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★ランスロット★★:皆と一緒でなくていいのか
	Talk(Actor002,"CHRNAME_NAMELES","speech","N","MA_01106_140002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor002,Camera002,EntryDataDuelCommonFormation01_03,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_103)
-- ▲直接出力

	--★★ノワール★★:周囲を警戒しておこうかと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_140004")

-- ▼直接出力
--ランスロット,CHRNAME_LANCELOT @名前変更
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:殊勝な心掛けだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_140005")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_140006")


	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_140007")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なぜ<br>なにも教えてくれないんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_140008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:『妖精殺し』が父さんなわけがない<br>あんたが父さんを殺すわけがない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_140009")


	--★★ランスロット★★:どうしてそう言い切れる？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_140010")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:信じたいからだ<br>ここまで導いてくれたあんたを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_140011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:昔から一緒にいてくれたあんたを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_140012")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor004,Camera004,EntryDataDuelCommonFormation01_01,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_101,Actor003,CharaPosDuelCommonFormation01_002,CharaPosDuelCommonFormation01_102)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
turn_chara(Actor002,-15,0.5)
-- ▲直接出力

	--★★イゾルデ★★:リンゴ狩りは好みに合わなかったかしら？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01106_140014")


	--★★トリスタン★★:集団の輪を乱しちゃいけないね<br>ランスロット先生？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_140015")


	--★★ランスロット★★:いつからそこに？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_140016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★トリスタン★★:安心して。なにも見てないし聞いてない<br>なにか起きたら弓を引くだけ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_140017")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
-- ▲直接出力

	--★★ランスロット★★:…だそうだ。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_140018")


	--★★イゾルデ★★:監視が取れたらご自由にどうぞ？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01106_140019")


	--★★ノワール★★:自由の身になるにはどうしたら？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_140020")


	--★★トリスタン★★:ランスロットに認められるとか？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_140021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:それはいいな<br>ケイに口利きしよう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_140022")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:しばらく、口は滑らせられないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01106_140024")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101160011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
