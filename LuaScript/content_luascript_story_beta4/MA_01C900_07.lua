-- このluaスクリプトは、MA_01C900_07.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
	-- 背景移動回転スケール
local bg = get_object("BG")
set_pos(bg,{0,0,24})

	-- 固定モブ移動回転スケール
local pro = get_object("Pro_1101_45")
set_pos(pro,{0,0,24})
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:おりょおりょ～？<br>ディナタン、なにしてるんだ？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070002")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,-112.383,0.2)
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:あっ、ガレスさん<br>…ちょっと、考えごとをしてました
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070003")

-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:ふ～ん
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:もしかして～<br>ノワールとまたケンカでもした？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:わたしで良ければ相談に乗るぞ～？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_071001")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:え…あ、いえ、そういうわけじゃ…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070007")

-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定2")
-- ▲直接出力

	--★★ガレス★★:最近は大丈夫か！<br>ならよかった！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070009")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:ないってわけじゃないですけど…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070010")


	--★★ディナタン★★:あの…ガレスさんたちは…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:うち？うちはしょっちゅうケンカしてた！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070013")

	change_face(Actor002,"Normal")

	--★★ガレス★★:ああ見えて好き嫌いが多くてさ<br>わたしの料理にすぐ文句言ってくるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:自分の皿だけ野菜を抜いてくれとか<br>ワガママ言うなー！って感じだろ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070015")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ふふ、そうなんですか…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:ガレスさんから<br>お兄さんを怒らせたことは？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガレス★★:それもしょっちゅう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070018")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "納得")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:じゃあ<br>秘密がバレて気まずくなったり…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070019")

-- ▼直接出力
 --PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:要するに、ディナタンはノワールに<br>なにか隠しごとでもしてるのか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070020")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:あ…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:いいっていいって。詳しくは聞かないよ<br>言いにくいこともあるだろうしさ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070022")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガレス★★:でも、もしその秘密でディナタンが悩んでるなら<br>ちゃんと話したほうがいい
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070023")

-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:なにも言わずに考えて悩んで<br>それで勝手に決められるほうが辛いからな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070024")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:それに間違ったことをしたときに<br>止めるのは兄妹の大事な役目だからな！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070025")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:あ…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070026")

-- ▼直接出力
 --PlayPartVoice("ガレス", "怒り")
-- ▲直接出力

	--★★ガレス★★:あ、もしかして言っても伝わらなかったとか？<br>ノワールって、ちょっとニブいもんな！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070028")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:まったく、兄貴ってのはどこも困ったもんだ<br>元気出していこうな、ディナタン！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:…はい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070031")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:よし！戻ってディナタンにうまいもん<br>作ってやる！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_070032")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:わあ、ありがとうございます
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_070033")

-- ▼直接出力
 --PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ガレス★★:腕をふるうぞ～！<br>そんで頑張って兄さんを止めるからな！
	Talk(Actor002,"CHRNAME_GARETH","speech","N","MA_01C900_070034")

	close_cutin()
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
