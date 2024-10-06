-- このluaスクリプトは、MA_01108_11.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor008")
	template1()
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:枯れちゃってたの<br>やっぱ宝石はね、あんまり出なくて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110002")

	change_face(Actor005,"Sad")

	--★★ラグネル★★:キャメリアードの鉱山ですか？<br>バルバロイいっぱい倒したのに…残念ですね
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01108_110003")

	change_face(Actor004,"Sad")

	--★★ガウェイン★★:わりぃ…殿下
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01108_110004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:なあに？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110005")


	--★★ガウェイン★★:キャメリアード…<br>復興進められてねーだろ？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01108_110006")


	--★★ガウェイン★★:ログレスの管理下には置かれてんだけどさ<br>カレドニアとの戦いが落ち着くまでは…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01108_110007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:アーサーから聞いた<br>しょーがないわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110008")


	--★★ガウェイン★★:俺もさ、ケイとかに食い下がったんだぜ<br>せっかく取り戻したのに放置はねーだろって
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01108_110009")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…うん。ありがと<br>でも平気。だから早く平和にしたいって思えるし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110010")


	--★★ギネヴィア★★:鉱山がバルバロイと戦う武器のもとになるなら<br>それはそれでいいよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110011")


	--★★ギネヴィア★★:がまんがまん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor007,Camera007,EntryDataDuelCommonFormation01_07,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_107)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,1.0,0.5)
keep_delay_ik_lookat(Actor002,Actor007,"J_Head",0.5)
-- ▲直接出力

	--★★ルーシャス★★:鉱山で取れたモノと言えば<br>ギネヴィアから貢がれた宝石があるのだがな？
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_110015")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:悲しいかな我が祖国は<br>皇太子殿下に搾取されちゃったわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110017")

	change_face(Actor007,"Smile")

	--★★ルーシャス★★:その一部で指輪を作らせたのだ<br>この作戦が成功した暁には褒美として贈呈しよう
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_110018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:しつっこいわねえ<br>要らないものを押し付けるのはただのエゴよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110019")

	change_face(Actor007,"Normal")

	--★★ルーシャス★★:そなたら小国の助けを得るなどと<br>借りを作るのもナンなのでな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_110020")


	--★★ギネヴィア★★:じゃあやっぱ完全に自己都合でしょソレ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラグネル★★:お礼がしたいっていうなら<br>ノワールにあげたらどうです？ルーシャス様
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01108_110023")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_110024")


	--★★ラグネル★★:この任務を選んでくれたのもノワールですし？
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01108_110025")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:おお、それはイイな<br>是非とも受け取ってくれ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_110026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:イイんだ…<br>それはそれでフクザツぅ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_110027")

	change_face(Actor007,"Smile")

	--★★ルーシャス★★:トモダチの証だ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01108_110029")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
