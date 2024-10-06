-- このluaスクリプトは、CO_101012_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_009)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,CharaPos110122_01_102)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
voice_play("VO_101009_sp_0003_1")
-- ▲直接出力

	--★★ノワール★★:話って、やっぱり例の件か？<br>みんなに避けられてるかもって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:ちょ、ちょっと兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020003")

	change_face(Actor002,"Anger")

	--★★ディナタン★★:そんな大きい声で言わないでってば！<br>変に大事にしたくないんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0054")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:わ、悪い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020006")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor002,Actor002,"J_Foot_L",0.6)
lookat_delay_weight(Actor002,0.5,0.1,0.8,0.2,0.6)
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:もう…兄さんったら…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020007")

-- ▼直接出力
CloseTalkWindow()
wait_time(2)
lookat_delay_weight_reset(Actor002,0.2)
wait_time(0.8)
-- ▲直接出力

	--★★ディナタン★★:自分のことは自分で、なんて大口叩いたのに<br>結局頼ることになっちゃうな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020009")


	--★★ディナタン★★:一応ね、頑張ってはみたんだよ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:自分から挨拶してみたり<br>困ってそうな子がいたら声をかけたりね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020011")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:でも…なんていうか<br>あまり手ごたえがなくって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん、そうなのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020013")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あ…別に意地悪されてるとかはないんだよ？<br>必要な会話はちゃんとできてると思うし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020014")

-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ただどうしても、距離を感じるっていうか…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:みんな、遠巻きに私を見るばかりで<br>喋りかけてくれないし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020016")


	--★★ディナタン★★:勇気を出して話しかけてみても、<br>顔を真っ赤にしてどっかいっちゃったりして
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101012_sp_0001_3")
-- ▲直接出力

	--★★ディナタン★★:ねえ、兄さん<br>どうしたらいいかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020018")


	--★★ノワール★★:そうだなあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_02020021","CO_101012_02020022","CO_101012_02020023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:気にしなくていいんじゃないか？<br>ひとりも悪くないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:楽しい学園生活に<br>仲の良いお友達は大切なんだよ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020026")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さんってもしかして…<br>「ひとりがかっこいい」とか思ってるタイプ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020027")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういうわけじゃないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:諦めずに声をかけてみよう<br>そのうち誰か友達になってくれるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:やっぱりそれしかないよね<br>でも、逃げられるとちょっとへこむんだよ～
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020031")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはそうだろうけど<br>…そもそも、なんで逃げたりするんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020032")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:無理して友達を作らなくても<br>俺がいるじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020034")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さんがそう言ってくれるのは嬉しいけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020035")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:でもせっかく学園に通ってるんだし<br>やっぱりお友達は欲しいよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020036")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、それもそうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020037")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
local gopos = {-0.273, 0, -13.321}
CloseTalkWindow()
setup_small_camera_start(RndCamera090)
Appear(Actor003)
turn_lookat_position(Actor003, gopos, 0)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003, gopos, 2)
wait_time(1)
setup_small_camera_end(RndCamera090)
setup_small_camera_start(Camera003)
wait_time(1)
turn_chara(Actor003,0,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:やれやれ<br>キミたち、周りが見えてないの？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_02020039")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002, 0.4, 0.08, 0.9, 0.6)
keep_ik_lookat(Actor002,Actor003, "J_Head")
setup_small_camera_end(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:トリスタンさん！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020040")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001, 0.4, 0.08, 0.9, 0.6)
keep_ik_lookat(Actor001,Actor003, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういう意味だよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020041")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:どういうって、そのままの意味だけど？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_02020042")

-- ▼直接出力

 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
lookat_weight_default(Actor001)
lookat_weight_default(Actor002)
set_common_look_at(Actor001,Actor002) --キャラクターに向く
set_common_look_at(Actor002,Actor001) --キャラクターに向く
 setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのままの意味って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020044")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:なぁ、今日こそはあの子に声かけようぜ！<br>お前行けって！
	Talk(Actor004,"NPCNAME_0151","speech","L","CO_101012_02020046")

-- ▼直接出力
PlayPartVoice("男子2", "照れ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:でも、兄貴が一緒にいるし…
	Talk(Actor005,"NPCNAME_0153","speech","L","CO_101012_02020047")

	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("現代男子", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ディナタンちゃん…やっぱかわいいなぁ<br>お近づきになりたい…
	Talk(Actor006,"NPCNAME_0154","speech","L","CO_101012_02020049")


	--★★キャメロット騎士学術院（男）③★★:この間はせっかく話しかけてくれたたのに<br>恥ずかしくて逃げてしまったけど、今度こそ…！
	Talk(Actor006,"NPCNAME_0154","speech","L","CO_101012_02020050")


	--★★ノワール★★:（…ああ、そういうことか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101012_02020052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:（避けられてるっていうより<br>意識されてる…って感じみたいだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101012_02020053")

-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力

	--★★ディナタン★★:兄さん？どうかしたの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020054")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0049")
-- ▲直接出力

	--★★ノワール★★:い、いや？なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02020055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:？変な兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02020056")


	--★★ノワール★★:（ディナタンは気づいていないんだな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101012_02020057")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（避けられてるわけじゃないなら<br>とりあえず友達の心配は必要なさそうだけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101012_02020058")


	--★★ノワール★★:（…別の心配がありそうだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101012_02020060")

-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
