-- このluaスクリプトは、CO_101065_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
 -- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、俺は外で待ってるから！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020002")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow() 
hide_image(BLACK_WHITE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ふたりで子供の服の買い出しなんて<br>事情を知らない人に見られたら誤解される…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020004")


	--★★ノワール★★:実際、店員さんは<br>俺とキッスさんの子供と勘違いしてたしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:キッスさんはキッスさんで<br>笑ってるだけだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:最初から目的を知ってたら断ったのに！<br>またキッスさんに遊ばれてる…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020007")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…でも、子供の服をあんなに大量に買って<br>なにに使うつもりなんだろ、キッスさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020009")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0.6} , 1)
 keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)                                
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:む、ノワールか
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020012")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:ひとりかね？<br>こんなところでなにを？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺はちょっと…<br>…いや、なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020015")


	--★★ノワール★★:（ケイにまで変な誤解されたらたまらないな<br>ここは黙っておこう…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101065_04020016")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:なにやら歯切れが悪いが…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:まぁいい。それより、以前<br>貴公に依頼した件はどうなっている？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020018")


	--★★ケイ★★:例のバルバロイ信者どもの噂だ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020019")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あー、それが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_04020022","CO_101065_04020023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:頑張ってはいる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020025")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:努力はしているが満足いく結果は出せていない、と
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ありていに言えば、まあ、そうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:正直あまりかんばしくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020029")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:随分と素直だな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020030")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:変に誤魔化しても嫌味を言われるだけだろうからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020031")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ケイ★★:本人に面と向かって口にする度胸には敬意を表するとしよう
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020032")

	goto Block1end

::Block1end::
	change_face(Actor003,"Normal")

	--★★ケイ★★:しかしやはり、あの依頼は貴公には荷が重かったようだな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020034")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:別になにもしてないわけじゃないからな…成果に乏しいのは確かだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020036")

	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさんにも相談はしたけど大した情報が得られてないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ケイ★★:キッス殿に？…ほう
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020039")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ケイ★★:少なくとも貴公の目は節穴ではないということか…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020040")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020041")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたもキッスさんを知ってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020042")

-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor002)
turn_chara(Actor001,27,0)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:い、いや別に知り合いというわけでは…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020044")

-- ▼直接出力
PlayPartVoice("キッス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★キッス★★:あー！
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★キッス★★:ケイ卿じゃない！偶然ね～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020048")

	change_face(Actor002,"Normal")

	--★★キッス★★:最近全然お店に来てくれなくて寂しいわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020049")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:あんまり放っておくと女はヨソに行っちゃうから気を付けてね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:誤解されるようなことを言うな！私と貴女はそのような関係ではないだろう！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020051")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:もう相変わらずおカタいんだから♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020052")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ず、随分親しい関係なんだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020054")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:違う！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020055")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:公私ともに仲良しよ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020056")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（面白そうだから、このまま放っておこう）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101065_04020057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:ところでケイ卿とラビットちゃんも仲良しなの？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020058")

	open_select_window_tag(Actor001,"Normal","CO_101065_04020060","CO_101065_04020061")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、仲良しだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020063")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:やっぱりそうなのね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020064")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:そんなわけなかろう私は彼の学園入りに今も反対している
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020066")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…だ、そうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020067")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフッ。息の合ったやりとり微笑ましいわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020068")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうわけじゃないけど知り合いではある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020070")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:同じキャメロット騎士学術院の関係者としてな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020071")

-- ▼直接出力
PlayPartVoice("キッス", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:なるほどね～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020072")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイ信者についての噂の話ケイに調査を依頼されたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020074")

-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:そうだったの？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020075")


	--★★キッス★★:じゃあケイ卿が言ってたあの話ってラビットちゃんのことだったのね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★キッス★★:ホント…仲の良いことで♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020078")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（あの話…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101065_04020079")

-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:ン！ンッンー！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020081")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:もとより貴公の活躍に期待はしていなかったので私のほうでもヤツらについては調べていたのだが
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020082")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ケイ★★:残念ながら大した情報はつかめずにいる
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020083")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:少なくとも今のところ大きな実害は見られないってことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020084")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:だからといって野放しにできることでもない貴公には引き続き調査してもらうぞ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101065_04020085")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020086")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力

	--★★キッス★★:アタシも網を張っておくから期待してて♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_04020087")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:素直に期待していいのか悪いのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_04020088")

-- ▼直接出力
local trustParam = set_communication_rankup("キッス_コミュランク", "キッス_親密度")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
