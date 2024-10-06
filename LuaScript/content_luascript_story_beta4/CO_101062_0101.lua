-- このluaスクリプトは、CO_101062_0101.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:お買い上げありがとうございます！/またのお越しをお待ちしておりますね～！
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","CO_101062_01010002")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
template2()
Hide(Actor003)
setup_small_camera_start(RndCamera002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ずいぶん元気のいい接客だな/確か、マルイル…だったっけ？商人の
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010004")

-- ▼直接出力
--マルイル,CHRNAME_MARIL @名前変更
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:あ、ノワールさん！/なにかお探しですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010006")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:やあ、マルイル
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:特に買いたいものがあって/来たわけじゃないんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:そんなときこそ/ぼくの店に寄って行ってください！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010009")

	change_face(Actor002,"Normal")

	--★★マルイル★★:ぼくの店は豊富な品揃えが自慢なんです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010010")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:たとえ買いたいものがなくっても/品物を見ていただければ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010011")


	--★★マルイル★★:なにか/買いたくなっちゃうこと請け合いです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:さあ！さあさあ！/寄ってらっしゃい、見てらっしゃい！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（な、なんか怖い…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_01010014")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、せっかくだしなにか買っていこうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010015")

	open_select_window_tag(Actor001,"Normal","CO_101062_01010017","CO_101062_01010018","CO_101062_01010019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…あらためてそう言われると、/特に思いつかないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010021")

-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:あれ、そうなんですか？　/それは残念
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010022")

	change_face(Actor002,"Normal")

	--★★マルイル★★:ノワールさんってば、/若いのにずいぶん無欲なんですねぇ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010023")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか？/自分では意識したことないなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010024")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…でも、あんたに若いのにって言われるの/なんか変な気分だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな…強い武器とかがあれば欲しいかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010027")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:武器ですか！それならこちらにどうぞ/ちょうどいいのが入ったんです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010028")

	change_face(Actor002,"Normal")

	--★★マルイル★★:どんな盾でも貫くという矛とか/勇者にしか抜けない剣とかいろいろありますよ～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010029")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へ、へえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:気になるけど今日はやめとこうかな、ははは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010032")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな…なにか/女の子が喜びそうなものとかあるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010034")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:えっ、それってもしかして/意中のあの子へのプレゼント的なやつです？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010035")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうわけじゃなくて/せっかくだから妹になにか買ってやろうかと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010036")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:任せてください！女の子のハートを掴んじゃう/最高のプレゼントを見繕いますよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010037")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…聞いてないな、これ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010038")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:欲しいものが店頭になければ言ってください！/すぐ仕入れてきますから！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010040")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★マルイル★★:お客さんと品物の縁を繋ぐのが/商人の役目ですからね！！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010041")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:すごい自信だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010043")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:はい！それはもう！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010045")

	change_face(Actor002,"Normal")

	--★★マルイル★★:実はぼく、ここに来る前は/旅商人として世界中を回っていたんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010046")

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:だから仕入れの伝手がかなりあるんですよ～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010047")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなんだ/今は旅はしていないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010048")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:つい最近、ここにお店を出した新参者なんですよ/落ち着いたら、また旅商人も再開しますけどね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010049")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルイル★★:そういえば、ノワールさんも/少し前にこの街に来たんでしたっけ？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ/ここに来る前はカレドニアに住んでた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010051")


	--★★ノワール★★:住んでたっていっても/傭兵やってたし、あまり家にはいなかったけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010052")

-- ▼直接出力
PlayPartVoice("マルイル", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:へえ～/ぼくたち、なんとなく似てますね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:そうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010054")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルイル★★:そうですよ！…ということでノワールさん/新参者同士、仲良くしましょうね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010055")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、よろしくな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_01010056")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:じゃあ早速商談を！/ぼくからノワールさんへオススメするのは…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_01010057")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（や、やっぱりなんか怖い…！？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_01010058")

-- ▼直接出力
local trustParam = set_communication_acquired("マルイル_コミュランク", "マルイル_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
