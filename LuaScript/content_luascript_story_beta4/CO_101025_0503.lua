-- このluaスクリプトは、CO_101025_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
DontChangeRandomCamera(true)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
set_rot(Actor001,{0,15,0})
set_rot(Actor002,{0,70,0})
set_pos(Actor003,{0.3,0,5.8})
set_rot(Actor003,{0,-155,0})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
lookat_weight_default(Actor001)
lookat_weight_default(Actor002)
lookat_weight_default(Actor003)
lookat_weight_default(Actor004)
lookat_weight_default(Actor005)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:なにがあったんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030002")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力

	--★★市民（男）②★★:子供がひとり<br>行方不明になったんだってよ
	Talk(Actor004,"NPCNAME_0193","speech","L","CO_101025_05030003")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "悩む")
-- ▲直接出力

	--★★市民（中年男）②★★:「儀式のはじまりだ」<br>っていうメッセージが遺されてたらしい
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_05030004")

	PlayAction(Actor005,"to  Std_Sad02")

	--★★市民（中年男）②★★:『魔女の儀式』のためにさらわれたのかもな<br>あの奥さんもかわいそうに…
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_05030005")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:『魔女の儀式』？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030006")

-- ▼直接出力
setup_small_camera_start(Camera002)
set_rot(Actor001,{0,-15,0})
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:…バルバロイを信奉する教団のウワサは<br>聞いたことあるかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_05030009","CO_101025_05030010")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、何度か耳にしてる<br>この誘拐はそいつらの仕業なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030012")

-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:まだそれを判断できる<br>材料はそろっていないけれど…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:わたしは違うと思うわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、ないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030016")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:カンタンにいえば、バルバロイに生贄を捧げて<br>自分たちは喰われることを許してもらおう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030017")

	change_face(Actor002,"Normal")

	--★★クレア★★:あわよくばバルバロイに護ってもらおう<br>そんなことを考える教団よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030018")

	change_face(Actor002,"Normal")

	--★★クレア★★:…バルバロイを後ろ盾に<br>悪事をはたらいている、という噂もあるわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030019")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この誘拐はそいつらの仕業なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030020")

-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:まだそれを判断できる<br>材料はそろっていないけれど…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:わたしは違うと思うわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030022")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:教団はときおり人をさらっては儀式を行い<br>バルバロイや…魔女を増やすというわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それが『魔女の儀式』か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030025")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:どうする？バルバロイが絡むなら<br>アーサーに相談して騎士を出してもらうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:念のため連絡をしておいてもいいと思うけれど…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030027")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
-- ▲直接出力

	--★★ノワール★★:けれど？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030028")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{-1.4,0,2.2},1)
wait_time(0.8)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力

	--★★ヴォールス★★:クレア、少し遅かったようだ<br>隠れ家はもぬけの殻だった
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_05030030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor003)
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,50,1)
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:なにか手がかりが残っているかもしれない<br>行ってみましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030031")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, FADE_TIME,false,false)
set_scale_image(20,20)
wait_time(FADE_TIME + TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:ここがあの男の隠れ家か？<br>暗いし、すごい匂いだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030033")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？なにか足に当たった…<br>ど、動物の死体かこれ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030034")


	--★★ノワール★★:この瓶に入っているのは…血か！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030035")

	change_face(Actor002,"Anger")

	--★★クレア★★:調査をはじめるわ<br>ヴォールスは向こう、ノワールはそっちを
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030036")


	--★★ヴォールス★★:わかった
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_05030037")

	open_select_window_tag(Actor001,"Normal","CO_101025_05030039","CO_101025_05030040")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:い、いや、俺この部屋を調べるのはちょっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030042")

	change_face(Actor001,"Sad")

	--★★ノワール★★:外で待っていていいかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030043")

-- ▼直接出力
PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:…好きにするといいわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030044")

-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:俺がノワールのぶんも働けばいいことだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_05030045")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった、任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030047")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ありがとう<br>気持ち悪くなったら外で休んでいいわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030048")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなわけにはいかない<br>クレアこそ平気なのか？その…血、とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030049")

	change_face(Actor002,"Normal")

	--★★クレア★★:心配いらないわ<br>他の現場で何度も見ているもの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030050")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
template2()
set_rot(Actor002,{0,-90,0})
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
lookat_weight(Actor001,0.6,0.03,0.7,0)
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor003,false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
setup_small_camera_start(RndCamera001)
wait_time(TIME_ELAPSED)
hide_image(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:とんでもない部屋だったな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030053")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:どうやら動物の内臓や血を抜き取って<br>あの部屋で保管していたようね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030054")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:あの男が<br>『血の蒐集家』なんだろうか？
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_05030055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:血の蒐集家？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030057")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:連続殺人犯よ。海の向こうで何回か事件を起こし<br>今はこのブリテン島に潜伏しているらしいわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030058")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★クレア★★:「忘れたほうが良かったと思えるくらい<br>悲劇の記憶を刻んでやる」
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030059")


	--★★クレア★★:そんなメッセージとともに<br>見るも無残な遺体を残していくの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030060")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クレア★★:かなり高位の魔法使いであると聞くわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030061")

	change_face(Actor001,"Sad")

	--★★ノワール★★:見るも無残、ってのは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:内臓を抜き取られたり<br>血をぜんぶ抜き取られたり…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030063")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:そこから<br>『血の蒐集家』という異名が付けられた
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_05030064")

	open_select_window_tag(Actor001,"Normal","CO_101025_05030066","CO_101025_05030067")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの男が血の蒐集家かどうかは<br>わからないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030069")

	change_face(Actor001,"Normal")

	--★★ノワール★★:子供があの男にさらわれたとすると<br>大変な事件になりかねない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030070")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:すぐ、行方を追わないと！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030071")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:そうね、調査を続けましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030072")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ずいぶん詳しいけど、クレアとヴォールスは<br>血の蒐集家を追っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030074")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:そんなところよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030075")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:自分としては<br>あまり無茶をしてほしくないのだがな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_05030076")

	goto Block3end

::Block3end::
-- ▼直接出力
setup_small_camera_start(RndCamera001)
change_face(Actor001,"Normal")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:男はロンディニウムの魔法道具屋で<br>なにかを手に入れようとしていた
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030078")


	--★★クレア★★:それが手に入るまでは<br>たとえ子供をさらっていたとしても
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030079")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クレア★★:事件は起こさないと思うわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_05030080")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その前に<br>男の行方をつかまないとだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05030081")

-- ▼直接出力
local trustParam = set_communication_rankup("クレア_コミュランク", "クレア_親密度")
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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
