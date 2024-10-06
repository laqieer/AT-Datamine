-- このluaスクリプトは、CO_101034_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("104000030", "content_still_10400003_image", "104000030_StillImage")
set_enable_auto_lookat_all(false)
set_rot(Actor001,{0,-95,0})
set_rot(Actor002,{0,92,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:やはりあの村に<br>人の気配はなかったわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020002")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ひょっとしたら生存者がいるかもと<br>期待したんだけどな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★エクセリア★★:………
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020006")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:彼のことを思い出していたの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:あなたも知っているでしょう？<br>バルバロイ憑きの末路を
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020008")


	--★★エクセリア★★:バルバロイは人に取り憑くことがある<br>取り憑かれた人間は少しずつ意識や記憶を喰われ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020009")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★エクセリア★★:次第に<br>自分が誰だかわからなくなっていって…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020010")


	--★★エクセリア★★:すべての記憶が喰いつくされたとき<br>人間ではなくなり
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020011")


	--★★エクセリア★★:同時に<br>周りの人間からその存在の記憶が忘れ去られる
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020012")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力

	--★★エクセリア★★:あの人はわずかに残った記憶に従い<br>この森や村を守っていたのかもしれない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エクセリア★★:私たちはそんなあの人を討ってしまった<br>それは正しいことだったのかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_08020016","CO_101034_08020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:正しいことだったんじゃないかと<br>俺は思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020019")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:どうして？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:存在がすべて失われる前に倒せたから俺とキミはあの人のことをまだ覚えている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの人を弔ってやれる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:…そうね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺にはわからないひょっとしたら、正しくなかったのかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020025")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:完全に喰われてしまうまでこの森で生活させてあげるべきだった？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:…私にも、わからない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:私、聞いたことがあるの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020029")


	--★★エクセリア★★:記憶をなくして一番寂しいのはそれを自覚したときなんですって
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020030")


	--★★エクセリア★★:なにかがあったはずなのに<br>誰かがいたはずなのに
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020031")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
-- ▲直接出力

	--★★エクセリア★★:自分のなかにぽっかりと空白ができて２度とそれを埋めることができない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020032")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…悲しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020033")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★エクセリア★★:でも…空白ができたと自覚できたならまだ幸せかもしれない、なんて考えたりもする
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020034")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？それはどういう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:…私には記憶がないの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020036")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:バルバロイに奪われたのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力

	--★★エクセリア★★:そうかもしれないしそうでないかもしれない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020038")


	--★★エクセリア★★:昔の私を知っている人は誰もいないから…私自身も含めて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020039")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:そっ…それはおかしいじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020040")


	--★★ノワール★★:バルバロイに喰われたり聖遺物化してエクセリアのことを忘れるならわかる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020041")


	--★★ノワール★★:でも、エクセリアは今ここにいるのに誰もキミのことを知らないって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020042")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そう、おかしいのよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:ねえ、教えてノワール私は誰なの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020044")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:エクセ、リア…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020045")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{5.19,0,1.55},3.2)
turn_chara(Actor002,80,0.5)
wait_time(0.2)
setup_small_camera_start(RndCamera006)
wait_time(1.8)
setup_small_camera_start(RndCamera008)
wait_time(1.2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力

	--★★エクセリア★★:記憶を失う者、他者の記憶から忘れられる者<br>そして過去の記憶を持たない者
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020046")


	--★★エクセリア★★:一番寂しいのは誰なのかしらね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08020047")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor002)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？花？エクセリアが供えたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020049")

-- ▼直接出力
ShowImageItem("104000030")
-- ▲直接出力

	--★★ノワール★★:これは…<ruby=わすれなぐさ>勿忘草</ruby>…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08020050")

-- ▼直接出力
local trustParam = set_communication_rankup("エクセリア_コミュランク", "エクセリア_親密度")
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
load_image_preload("104000030", "content_still_10400003_image", "104000030_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
