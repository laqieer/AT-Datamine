-- このluaスクリプトは、CO_101066_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_02","112011_02_h")
Include("content_adv_advsmall_112011_02","Template112011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",60,CharaPos112011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_003)
	Camera002 = SetTemplate("Actor002",-60,CharaPos112011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112011_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName112011_02,CameraPos112011_02_005)
	InitializeTemplateRandomCamera112011_02()
	InitializeTemplate112011_02()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0001")
-- ▲直接出力

	--★★ブレイズ★★:おっ！おぬし<br>このあいだ編入してきたノワールじゃな！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010002")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:そうだけど…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010003")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:おぬしの活躍はマーリンから聞いておるぞ～<br>どんな強敵にも怯むことなく立ち向かう勇敢さ…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力

	--★★ブレイズ★★:まるで大魔法使いとして名を馳せた<br>若い頃のワシを見ているかのようじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:はあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010006")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ブレイズ★★:懐かしいのう。ワシがおぬしくらいの頃は<br>世界を股にかけた大冒険をしたもんじゃった
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010007")


	--★★ブレイズ★★:そう、あれは確か海を越えた大陸で…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010008")

-- ▼直接出力
setup_small_camera_end(Camera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…で、俺になにか用か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010009")

-- ▼直接出力
setup_small_camera_start()
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:おお、すまんすまん。おぬしの活躍を見込んで<br>ちと頼みたいことがあってのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:ワシは、この学園で教師をしながら<br>日々バルバロイの研究にいそしんでおる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010011")

	open_select_window_tag(Actor001,"Normal","CO_101066_01010013","CO_101066_01010014","CO_101066_01010015")
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
setup_small_camera_end()
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さすがに知ってるよ<br>授業を受けたことあるしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010017")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:おお、しっかり覚えておるようじゃな<br>感心、感心じゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010018")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:まぁ、小テストの成績は散々じゃったが<br>今度返すから、楽しみにしておるんじゃぞ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010019")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは楽しみにしたくないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:教師？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010022")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0029")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:こら！ワシを誰だと思っとったんじゃ！<br>バルバロイ学のブレイズ先生じゃろ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0015")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:さてはおぬし、授業中寝とったな！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010024")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイの研究？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:バルバロイどもを打ち倒すためには<br>まずやつらの実態を知らねばじゃろう？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ワシはそんな研究の第一人者なのじゃよ！<br>まぁ、他に研究してる者はほとんどおらんがの～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010028")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:バルバロイの調査は危険が伴う<br>それゆえ、研究があまり進んでおらんのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010030")

-- ▼直接出力
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:そこでじゃ！ワシの研究におぬしの力を<br>ぜひとも借りたいと考えておるのじゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010031")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:協力は構わないけど<br>俺に出来ることがあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010032")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0039")
-- ▲直接出力

	--★★ブレイズ★★:もちろんじゃとも<br>おぬしにしかできぬことがあるのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:なんだかよくわからないけど…協力するよ<br>バルバロイを倒すためだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010034")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:おお、そうかそうか！感謝するぞ～<br>それじゃ、お礼にこれをやろう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to EatIdle")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ノワール★★:これは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010037")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:市街のマーケットで買ってきたクッキーじゃ<br>美味じゃぞ～。ほれ、食ってみい！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
se_play("SE_ADV_MA_01C110_35_Food_Eat")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それじゃ…ぱくっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010039")

-- ▼直接出力
wait_time(0.2)
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
set_enable_auto_lookat(Actor001, false)
PlayActionDirect(Actor001,"to  Std_Surp")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:………うぐっ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:おお、ひっくり返るほど美味いか～♪<br>それじゃ、ワシもいただくかの～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010042")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(true) 
-- ランダムカメラを一時的にOFF
EntryWalk(Actor003,Camera003,EntryData112011_02_05,CameraAssetBundleName112011_02,CameraPos112011_02_105)
DontChangeRandomCamera(false) 
-- ランダムカメラを再びON
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルガン","0045")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★モルガン★★:あらら、ノワールくんどうしたの？<br>こんなところでのたうちまわって
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010044")


	--★★ノワール★★:しょ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010045")


	--★★モルガン★★:しょ？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010046")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0043")
PlayActionDirect(Actor001,"to  Std_Sad02")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ノワール★★:しょ、しょっぱい…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010047")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
	PlayAction(Actor003,"to Sit01_BA01")
-- ▼直接出力
PlayPartVoiceDirect("モルガン","0002")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:ブレイズ先生…もしかして<br>ノワールくんに塩クッキーをあげたの？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:うむ。ワシのお願いを聞いてくれると言うのでな<br>お礼に少し分けてやったんじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010050")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルガン","0028")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★モルガン★★:やっぱり！もう、先生ったら<br>あんな塩分の塊、普通の人は食べられませんよ<br>
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010051")

-- ▼直接出力
setup_small_camera_end(RndCamera007)
-- ▲直接出力
	PlayAction(Actor003,"to Sit02_Talk")
-- ▼直接出力
PlayPartVoiceDirect("モルガン","0013")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:大丈夫、ノワールくん？<br>ブレイズ先生はとにかく塩辛いものが好きなの
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010052")

-- ▼直接出力
PlayPartVoiceDirect("モルガン","0019")
-- ▲直接出力

	--★★モルガン★★:先生も少しは控えてくださいね<br>いくらなんでも、体を壊しちゃいますよ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010053")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:これくらい塩分を取らんと脳が働かんのじゃよ～<br>心配せんでも、ワシはすこぶる健康体じゃて！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010054")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力

	--★★ブレイズ★★:ま、麗しのモルガンちゃんに心配されるのは<br>悪い気はせんがのう～♪
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010055")

-- ▼直接出力
PlayPartVoiceDirect("モルガン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モルガン★★:もう、先生ったら
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010056")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:そんなことよりモルガンちゃん<br>ワシになんぞ用かの？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010058")

	PlayAction(Actor003,"to Sit02_Talk")
-- ▼直接出力
PlayPartVoiceDirect("モルガン","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:ああ、そうでした<br>良い茶葉が入ったので一緒にお茶でもと思って
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101066_01010059")

	PlayAction(Actor003,"to Sit02_Loop")
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ふぉっふぉっふぉ！<br>それはいいのう！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010060")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ノワールの調子も悪そうじゃし<br>手伝ってもらうのはまた今度にするかの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010061")

-- ▼直接出力
setup_small_camera_start(RndCamera011)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:ノワール。ワシはいつもここにおるから<br>おぬしの都合の良いときに研究に付き合ってくれ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010062")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0006")
-- ▲直接出力

	--★★ブレイズ★★:ではの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_01010063")

-- ▼直接出力
--ブレイズ,モルガン退場
CloseTalkWindow()
fadeout(0,0,0,0.5, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor003)
PlayActionDirect(Actor001,"to  Std_Sad02")
SkipDefaultMotion(Actor001)
setup_small_camera_start(RndCamera090)
wait_time(0.3)
--フェードアウト
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力

	--★★ノワール★★:み、水…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_01010065")

-- ▼直接出力
local trustParam = set_communication_acquired("ブレイズ_コミュランク", "ブレイズ_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
