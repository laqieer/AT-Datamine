-- このluaスクリプトは、CO_101035_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Pod = get_object("geo_tea_set05")
set_pos(Pod, {0,0,-10.65})
prop001=setup_prop_object(10103005)
prop001_offset={-0.17,0,0,0,-90,-180}
on_parent(prop001,Actor001, "J_Hand_L", prop001_offset)
on_active(prop001)
prop002=setup_prop_object(10103002)
set_pos(prop002,{-0.4,0.81,-11.35})
set_rot(prop002,{0,70,0})
off_active(prop002)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Reading")
set_pos(Actor003,{-0.33,0,-13.1})
set_rot(Actor003,{0,-20,0})
Hide(Actor003)
set_pos(Actor004,{0.6,0,-13.5})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:ごちそうさまでした<br>…ノワールさん、なんの本を読んでるんです？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020002")

-- ▼直接出力
lookat_weight(Actor001,0.5,0.03,0.7,0)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:農業についての本だよ<br>学園の大図書院で借りてきたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020003")

-- ▼直接出力
PlayActionDirect(Actor001,"to Sit01_Loop")
lookat_weight(Actor002,0.5,0.03,0.7,0)
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:リリアーナの仕事を手伝っているうちに<br>興味が湧いてきちゃってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020004")

-- ▼直接出力
setup_small_camera_start(Camera002)
off_parent(prop001)
off_active(prop001)
on_active(prop002)
Appear(Actor003)
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:わぁ…！勉強熱心ですね<br>私も見習わなきゃ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera003)
change_face(Actor001,"Normal")
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:兄さん、今ランチ？<br>私も一緒にいいかな？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020007")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★リリアーナ★★:ひゃあああっ！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","N","CO_101035_04020008")

	close_cutin()
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
set_rot(Actor002,{0,-100,0})
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろん<br>リリアーナもいいよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
set_rot(Actor003,{0,25,0})
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力

	--★★リリアーナ★★:全然！全然大丈夫です！<br>私は帰りますから、おふたりでゆっくり…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020011")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:えっ？せっかくだし<br>リリアーナさんともお喋りしたいな
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020012")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ディナタン★★:同じ学園で生活してるのに<br>あまり話す機会もないじゃない
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:は、はい、でも、あの、私…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:そんなに身構えないでいいよ？<br>なんか私まで緊張しちゃうから
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力

	--★★リリアーナ★★:はい…すみません…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020016")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:でも、知らなかったな<br>ふたりが仲良かっただなんて
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020018")

-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:最近、ノワールさんが畑を手伝ってくれて…<br>それで…その…お話、するようになって
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020019")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:畑？クラブ活動か何かってこと？学園に畑なんてあったっけ？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力

	--★★リリアーナ★★:あぅ、えっと、えっと…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020022")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
wait_time(0.3)
lookat_weight(Actor003,0.5,0.03,0.7,0)
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:ディナタン落ち着け<br>リリアーナが困ってるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020023")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
-- ▲直接出力

	--★★ディナタン★★:あっ、ご、ごめんね…つい…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★リリアーナ★★:いえ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020025")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:リリアーナがひとりで作った畑があるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020026")

-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:街から少し離れているのですがアーサー様のご厚意で場所を用意していただいて
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020027")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Surp")
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力

	--★★ディナタン★★:ひとりで作ったの？それってすごいことじゃない？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:細かく手入れも行き届いているんだ感心したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:そんな…全然…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020030")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
PlayPartVoice("ディナタン", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:私もカレドニアに住んでいた頃ちょっとだけ畑仕事やったことあるんだ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020031")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:家の裏のちっちゃな畑だけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020032")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:もし人手が必要なら言ってね？私も手伝うから！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_04020036","CO_101035_04020037")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:強引なタイプが苦手なら断ってもいいんだぞ、リリアーナ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020039")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ディナタン★★:それ、どういうこと？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020040")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:いえいえ！ディナタンは全然苦手じゃないです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020041")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:お手伝い、すごく嬉しいですディナタンがいいならお願いしたい…です
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020042")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:うん、任せて！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020043")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:人手は多いに越したことはないだろお願いしよう、リリアーナ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020045")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:ディナタンに畑仕事…！？そんな、とんでもない…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020046")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺の妹はこう見えて働き者だから安心していいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020047")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ディナタン★★:こう見えてってどういうこと？でもまあ、兄さんより役立つのは確実ね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020048")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだと！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020049")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:本当のことでしょ？戦うことと裁縫以外、全然じゃない
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020050")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うぐぐ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020052")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ふふっ頼りにさせてもらいます、ふたりとも
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020053")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:今度畑に行くときは絶対に声をかけてね！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:は、はい…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえばクレアも気になってるみたいだったな<br>クレアも誘うか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020057")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor004)
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力

	--★★リリアーナ★★:クレアが？どうして？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020058")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera004)
set_enable_auto_lookat_all(true)
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:放課後、様子がおかしいからよ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020060")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★リリアーナ★★:ひゃっ！？ク、クレア…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","N","CO_101035_04020061")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor004,{0,-30,0})
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:リリアーナが放課後になにをしていたか<br>わかったんだ。知りたくないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クレア★★:畑仕事をしていたんでしょう？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020063")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:知ってたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020064")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:あなたとリリアーナの爪のあいだに入った土そしてテーブルの上に広げられた農業の本
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020065")


	--★★クレア★★:簡単な推理よ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020066")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:事情を知っていたのなら話が早い<br>クレアもリリアーナの畑仕事を手伝わないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020067")

-- ▼直接出力
PlayPartVoice("クレア", "驚き")
-- ▲直接出力

	--★★クレア★★:わたしが？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020068")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:賛成！<br>クレアさんも一緒にやりましょうよ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020069")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力

	--★★リリアーナ★★:ふ、ふたりともそんな強引に誘っちゃ…<br>クレア、断ってもらって構いませんから
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020070")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:…面白そうね
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020071")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:えっ？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")

	--★★クレア★★:これまで畑仕事なんて挑戦したことなかったから<br>…わたしの好奇心が刺激されてきたわ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020073")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ぜひ、誘ってちょうだい<br>楽しみにしているわ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","CO_101035_04020074")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{-3,0,-13.5},2.5)
turn_chara(Actor004,-90,0.3)
wait_time(2)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_rot(Actor003,{0,0,0})
Hide(Actor004)
setup_small_camera_start(RndCamera005)
set_enable_auto_lookat_all(true)
lookat_delay_weight_reset(Actor002,1)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★リリアーナ★★:…嬉しいです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020076")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020077")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:みんなに<br>畑仕事に興味をもってもらえて
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020078")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:気分転換したいんじゃないかな<br>授業だ、戦争だ、の毎日だもん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020079")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:言われてみれば<br>コルベニック城のみんなもそうでした
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020080")


	--★★リリアーナ★★:最初はフィエナが手伝ってくれて<br>そのあと他のみんなを連れてきてくれて
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020081")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:その光景、なんとなく想像できるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020082")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:だね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101035_04020083")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
-- ▲直接出力

	--★★リリアーナ★★:嫌がると思っていたエクセリアが<br>すごく興味を持ってくれたのが意外でした
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020084")

	change_face(Actor002,"Smile")

	--★★リリアーナ★★:野菜を育てるよりも<br>別のことに興味があったのかもしれませんけどね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020085")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:マターヤは「汚れるからパス」なんて言いながら<br>いつも遅くまで付き合ってくれました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020086")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:あとで、エクセリアも誘ってみようか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_04020087")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はい<br>きっと喜んでくれると思います
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_04020088")

-- ▼直接出力
local trustParam = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")
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
setup_prop_object_preload(10103005)
prop001_offset={-0.17,0,0,0,-90,-180}
setup_prop_object_preload(10103002)
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
