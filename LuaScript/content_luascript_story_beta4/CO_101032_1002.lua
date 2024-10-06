-- このluaスクリプトは、CO_101032_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
lookobj = create_object("kara")
set_pos_object(lookobj,0.283,1.0,-11.637)
keep_ik_lookat_object(Actor001,nil,"kara")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor004,0.4,0.08,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんか緊張するな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:まずはオードブル<br>『こだわり山菜の木の実和え』だ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
keep_delay_ik_lookat_object(Actor001,nil,"kara",1.1)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:山菜がダメなガウェインでも食べられるように<br>木の実が合えてあるんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020005")


	--★★ノワール★★:木の実の風味が鼻に抜けていく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:苦みやエグみはほとんど感じない<br>むしろ甘く感じるくらいだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020008")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:細かく砕いた木の実の触感もいい<br>美味しいよ、ガレス！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020009")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Appear(Actor003)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
DontChangeRandomCamera(true) 
SkipOffsetCamera(Camera003)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力

	--★★リオネス★★:次は<br>『炭鉱キノコのテールスープ』だ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_10020011")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:テールスープ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020012")

-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara",1.1)
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:美味い！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マイントリュフのスープはたしかに<br>美味しかったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020015")

	change_face(Actor001,"Smile")

	--★★ノワール★★:若干パンチが足りないかなと思っていたんだ<br>それを牛テールが補っている！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.7)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力

	--★★リオネス★★:育ち盛りの学生に<br>炭鉱夫向けのスープを出しても物足りなさそう
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_10020017")


	--★★リオネス★★:そう考えたガレスが<br>アーキペラゴ牛のテールで出汁をとったんだ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_10020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>あのスープを改良してくれたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ガレス★★:さあ、どんどん行くぞ<br>次は『ナイトカジキの香草焼き』だ
	Talk(Actor002,"CHRNAME_GARETH","speech","N","CO_101032_10020021")

-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara",1.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:これも美味そうだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020022")

	close_cutin()
-- ▼直接出力
 --暗転＆時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor002)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true) 
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★ノワール★★:…ふう、食べた食べたご馳走様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:どうだった？<br>美味しかっただろう♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020025")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_10020027","CO_101032_10020028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん美味しかった！これまで食べた料理のなかで一番だった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020030")

-- ▼直接出力
PlayPartVoice("グリフレット", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★料理人★★:俺の料理よりも美味いってか？
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_10020031")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うっ！？<br>こ、コック長の料理も負けないくらい美味いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020032")

	change_face(Actor004,"Normal")

	--★★料理人★★:ったく、どいつもこいつも調子がいいことで
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_10020033")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:これならガウェインも満足するはず！俺が保証するよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020035")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:本当か？ノワールが保証してくれるなら間違いないな！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020036")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:頑張った甲斐があったぞ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020037")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:ノワールわたし、決めたんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020039")


	--★★ガレス★★:兄さんに会って伝える兄さんがやってることは間違いだって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020040")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガレス★★:みんなにごめんなさいをしなきゃもうご飯を作ってあげないぞって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:こんなに美味しいご飯を食べられないなんてガウェインも泣いて謝ってくるぞ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10020043")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:だな！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_10020044")


	--★★ガレス★★:わたしやリオネス、それにノワール<br>大切な家族たちがずっと待ってる
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガレス★★:あんまり待ってるとご飯も冷めちゃう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020046")


	--★★ガレス★★:「家族を大事にしなきゃ」って言ったのは他でもない兄さんなんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020047")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:たっぷりお灸を据えてやらないとな！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:たっぷり…お灸を…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10020050")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
