-- このluaスクリプトは、EA_004_042.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_005)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
set_pos(Actor001,{1.941,0,7.06})
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
lookobj = create_object("kara")
set_pos(lookobj,{2.7533,0.814,10.551})
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat_object(Actor002,nil,"kara")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_weight(Actor003,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
prop_001    = load_particle("content_prop_10103001", "10103001_PropModel", false, false)
set_pos(prop_001,{2.7533,0.814,10.551})
set_rot(prop_001,{0,2.272,0})
prop_002    = load_particle("content_prop_10103002", "10103002_PropModel", false, false)
set_pos(prop_002,{2.761,0.8525,10.551})
set_rot(prop_002,{0,-18.728,0})
prop_003    = load_particle("content_prop_10103003", "10103003_PropModel", false, false)
set_pos(prop_003,{2.7636,0.8904,10.551})
set_rot(prop_003,{0,2.272,0})
prop_004    = load_particle("content_prop_10103004", "10103004_PropModel", false, false)
set_pos(prop_004,{3.051,0.813,10.636})
set_rot(prop_004,{0,152.3,0})
prop_005    = load_particle("content_prop_10106005", "10106005_PropModel", false, false)
set_pos(prop_005,{3.067,0.813,10.343})
set_rot(prop_005,{0,-1.6,0})
on_active(prop_001)
on_active(prop_002)
on_active(prop_003)
on_active(prop_004)
on_active(prop_005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.3)
wait_time(0.5)
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:ディンドラン<br>探してほしい本があるのだけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420006")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン","肯定")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:ええ。なかなか面白かったわ<br>欲しい情報は載っていなかったけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ディンドラン★★:それは残念。でも…私が言うのもなんだけど<br>本を読むより先に、すべきことがあるのでは？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420009")

-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0015")
-- ▲直接出力

	--★★エクセリア★★:？…あぁ、読み終わった本を<br>ちゃんと戻さないといけないわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420010")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン","否定")
-- ▲直接出力

	--★★ディンドラン★★:そう、それもそうなんですけどね<br>でも、それだけじゃなくてですね
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420011")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ディンドラン","落胆")
-- ▲直接出力

	--★★ディンドラン★★:…これはあの子が苦労するはずだわ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420013")


	--★★エクセリア★★:…？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420014")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor001)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat_position(Actor001,CharaPos110061_02_004[1],CharaPos110061_02_004[2],CharaPos110061_02_004[3],0)
slidemove(Actor001,CharaPos110061_02_004[1],CharaPos110061_02_004[2],CharaPos110061_02_004[3],2.3)
wait_time(2.3)
turn_lookat(Actor001,Actor003,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:あら、ノワールさん<br>貴方もなにか調べものかしら？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:まぁ、そんなところかな<br>貴方もってことは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420017")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,105,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:熱心な学生、２人目
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420018")


	--★★ノワール★★:『わかる！戦術概論』『指揮のススメ』<br>『一歩先へ進むための心理学』…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420021")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
wait_time(0.2)
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_004_0420023","EA_004_0420024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:すごいな…これ全部読んだのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:ええ。わからないことがあるときは、<br>まず先例が無いか調べるのが最適解だから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420029")

	change_face(Actor002,"Smile")

	--★★エクセリア★★:何か知りたいときは本を読むのが一番よ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:大図書院のお姉さんとしましては<br>嬉しい考えではあります
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420031")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:…とはいえ、今はまだ<br>答えは見つかってはいないけど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どれも基本的な本ばかりだな<br>エクセリアには必要ないんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そんなことないわ。基本に立ち返ることは重要<br>アダンもそう言っていたもの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420037")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なるほど…そういうものか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420038")

-- ▼直接出力
PlayPartVoice("エクセリア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:…とはいえ、私の疑問に答えてくれる本は<br>この中にはなかったのだけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420039")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:これだけ読んでわからないって…<br>エクセリアはいったい何が知りたいんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420041")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat_object(Actor002,nil,"kara",0.4)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:それは…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン","肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:直接、聞いてみたらどうですか？<br>それが一番早いですよ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420044")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
set_enable_auto_lookat(Actor002, true)
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:…そうね。そうかもしれないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420046")

-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…俺に関係ある話なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420047")

-- ▼直接出力
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:…このあいだの授業で、アダンは私から<br>あなたに指揮を代わるように言ったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420048")


	--★★エクセリア★★:そして実際、あなたは私以上の結果を出した<br>その要因が知りたいの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420049")


	--★★エクセリア★★:あなたはなにか心当たりはない？<br>あなたにあって、私に欠けているもの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420050")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そう言われてもなぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン","挨拶")
-- ▲直接出力

	--★★ディンドラン★★:…そういえば、ノワールさんって<br>前と少し雰囲気が変わったと思いません？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420053")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420054")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン","肯定2")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ディンドラン★★:ええ。なんだか大人の魅力を感じるというか<br>なんだか一皮むけたみたいな…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:もしかして…学園にいないあいだ、妖精の森で<br>なにか特別なことでもあったり？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420056")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:と、特別なこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420058")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ディンドラン","悩む")
-- ▲直接出力

	--★★ディンドラン★★:たとえば…そうですね<br>妖精の隠れ里に迷い込んで、その加護を得たとか
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420059")


	--★★ノワール★★:ああ、そういう話…<br>妖精の加護か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:なにか覚えがあるの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420062")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…いや、全然。正直、森での出来事は<br>あまり覚えていないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:思い出そうとすると<br>頭の中に靄がかかったみたいになって――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420064")

-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0013")
-- ▲直接出力

	--★★エクセリア★★:…森での記憶を失ってしまったのね<br>バルバロイに喰われたとか？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420065")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…それはないと思う<br>森の中ではほとんど襲われることもなかったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420066")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:むしろ、いつも守られていたような気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420067")

	change_face(Actor003,"Surprise")

	--★★ディンドラン★★:守られていた？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420068")

-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:なんとなく、そう感じるんだ<br>…よくはわからないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420069")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:…無理に思い出そうとしなくてもいいわ<br>あなたが嘘を言ってるとは思えないし
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420070")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★エクセリア★★:…それに、一度失われた記憶は<br>そう簡単に思い出せるものでもないもの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420071")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:…そうですね<br>私も無理強いする気はありません
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ディンドラン★★:もし妖精の隠れ里への道を知っているなら<br>道案内を頼みたいと思っていただけですから
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420073")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:でも結局振り出しに戻ってしまったわ<br>手がかりゼロね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420074")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0034")
-- ▲直接出力

	--★★エクセリア★★:いったい、私になにが欠けているのかしら…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420075")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:…なぁ、エクセリア<br>なんで授業のことをそこまで気にするんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420076")

-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:言っちゃなんだけど、キミは手伝いの立場だし<br>そこまで真剣に考えなくても…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420077")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:だって、このままじゃあなたたち<br>学園祭の準備が進まないでしょう？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420078")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420079")

-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力

	--★★エクセリア★★:言ったでしょ<br>できることがあれば手伝うって
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420080")


	--★★エクセリア★★:でも手伝うと言っても私にできることは<br>アダンに教わった戦術を教えることくらいだから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420081")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エクセリア★★:最適解の戦術を知れば、授業は効率的に進むわ<br>そうすれば、余った時間は準備に使えるでしょ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420082")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力

	--★★ノワール★★:あのスパルタ指導は学園祭のためだったのか…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420083")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:ええ。それに学園祭の準備だけじゃなくて<br>最適解はそのあとの戦いにも役立つはずよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420084")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エクセリア★★:アダンの戦術は、私に<br>戦う力と生きる術を与えてくれたから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420085")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat_object(Actor002,nil,"kara",0.4)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:でも指揮官から外された今ではそれも難しい<br>…やっぱり、アダンのようにはできないわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420087")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.4)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:…もう行くわね。それじゃ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0420089")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + 0.5)
Hide(Actor002)
se_play("SE_ADV_EA_004_042_Chair")
wait_time(0.2)
se_play("SE_ADV_EA_004_042_Walk")
wait_time(5.5)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン","肯定2")
-- ▲直接出力

	--★★ディンドラン★★:彼女、本当にアダン先生を信頼しているんですね<br>まるでお父さんを慕う娘さんみたい
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420092")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうですね。アダン先生もエクセリアのことは<br>相当気にかけているみたいですし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420093")


	--★★ノワール★★:父親、か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420095")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディンドラン★★:ノワール？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420096")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…あ、いえ。なんでも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420097")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それにしても…エクセリアのスパルタに<br>あんな理由があったなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420098")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:それがわかっているから、<br>あの子も私に相談してきたんでしょうね
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420099")


	--★★ディンドラン★★:『エクセリアの真意を皆に伝えられないか』って<br>でも彼女、そういうの得意じゃなさそうだし
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420100")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:そのうえあの子は肝心なところで奥手ですから…<br>まぁそこもかわいらしいのだけど
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420101")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あの、ディンドランさん<br>あの子って、もしかして――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420103")

-- ▼直接出力
PlayPartVoice("ディンドラン","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディンドラン★★:あ、いけない。ナイショなんでした！
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420104")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Normal")

	--★★ディンドラン★★:今私が言ってたこと<br>パーシヴァル様には秘密ですよ…？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420105")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:完全に言ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0420106")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン","肯定2")
-- ▲直接出力

	--★★ディンドラン★★:なんにせよ彼女が本に答えを求めているうちは<br>問題は解決しないでしょう
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420107")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:そうですねぇ… <dot>お節介な誰か</dot>が<br>強引に背中を押してあげたりでもしないと
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","EA_004_0420108")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_prop_10103001", "10103001_PropModel", false, false)
load_particle_preload("content_prop_10103002", "10103002_PropModel", false, false)
load_particle_preload("content_prop_10103003", "10103003_PropModel", false, false)
load_particle_preload("content_prop_10103004", "10103004_PropModel", false, false)
load_particle_preload("content_prop_10106005", "10106005_PropModel", false, false)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
